using System.Text.Json;
using DAL.Models;
using DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DAL.Data;

public class BookHubDBContext(DbContextOptions<BookHubDBContext> options)
    : IdentityDbContext<LocalIdentityUser, IdentityRole, string>(options)
{
    public DbSet<Book> Books { get; set; }

    public DbSet<BookGenre> BookGenres { get; set; }

    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<Author> Authors { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<LocalIdentityUser> LocalIdentityUsers { get; set; }

    public DbSet<WishListItem> WishListItems { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<BookImage> BookImages { get; set; }

    public DbSet<AuditLog> AuditLogs { get; set; }

    public int? CurrentUserId { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (
            var relationship in modelBuilder
                .Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())
        )
        {
            relationship.DeleteBehavior = DeleteBehavior.SetNull;
        }

        modelBuilder
            .Entity<BookImage>()
            .HasOne(bookImage => bookImage.Book)
            .WithMany(book => book.Images)
            .HasForeignKey(bookImage => bookImage.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Seed();

        modelBuilder.Entity<Book>().HasQueryFilter(e => e.DeletedAt == null);
        modelBuilder.Entity<Author>().HasQueryFilter(e => e.DeletedAt == null);
        modelBuilder.Entity<Publisher>().HasQueryFilter(e => e.DeletedAt == null);
        modelBuilder.Entity<Review>().HasQueryFilter(e => e.DeletedAt == null);
        modelBuilder.Entity<Genre>().HasQueryFilter(e => e.DeletedAt == null);
        modelBuilder.Entity<User>().HasQueryFilter(e => e.DeletedAt == null);

        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        TrackAuditLogs();
        UpdateEditedAt();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        TrackAuditLogs();
        UpdateEditedAt();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void TrackAuditLogs()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e.State is EntityState.Modified or EntityState.Deleted)
            .ToArray();

        foreach (var entry in entries)
        {
            var deletedAt = entry.Properties.FirstOrDefault(p => p.Metadata.Name == "DeletedAt");
            var action =
                deletedAt?.CurrentValue != null
                    ? nameof(EntityState.Deleted)
                    : entry.State.ToString();

            var auditLog = new AuditLog
            {
                UserId = CurrentUserId,
                EntityName = entry.Entity.GetType().Name,
                EntityId = entry
                    .Properties.FirstOrDefault(p => p.Metadata.IsPrimaryKey())
                    ?.CurrentValue.ToString(),
                Action = action,
                Changes = GetChanges(entry),
            };

            AuditLogs.Add(auditLog);
        }
    }

    private static string GetChanges(EntityEntry entry)
    {
        var changes = new Dictionary<string, object>();

        if (entry.State == EntityState.Modified)
        {
            foreach (var property in entry.Properties)
            {
                if (
                    property.IsModified
                    && property.CurrentValue?.ToString() != property.OriginalValue?.ToString()
                )
                {
                    changes[property.Metadata.Name] = new
                    {
                        Original = property.OriginalValue,
                        Current = property.CurrentValue,
                    };
                }
            }
        }

        return JsonSerializer.Serialize(changes);
    }

    private void UpdateEditedAt()
    {
        var modifiedEntries = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified);

        foreach (var entry in modifiedEntries)
        {
            var editedAtProperty = entry.Entity.GetType().GetProperty("EditedAt");

            if (editedAtProperty != null && editedAtProperty.PropertyType == typeof(DateTime?))
            {
                editedAtProperty.SetValue(entry.Entity, DateTime.UtcNow);
            }
        }
    }
}

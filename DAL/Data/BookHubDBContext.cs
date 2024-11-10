using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public class BookHubDBContext(DbContextOptions<BookHubDBContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }

    public DbSet<BookGenre> BookGenres { get; set; }

    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<Author> Authors { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<WishListItem> WishListItems { get; set; }

    public DbSet<Order> Orders { get; set; }

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
        UpdateEditedAt();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateEditedAt();
        return base.SaveChangesAsync(cancellationToken);
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

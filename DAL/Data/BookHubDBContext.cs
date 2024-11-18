﻿using DAL.Models;
using DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public class BookHubDBContext(DbContextOptions<BookHubDBContext> options)
    : IdentityDbContext<LocalIdentityUser, IdentityRole, string>(options)
{
    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookGenre> BookGenres { get; set; }

    public virtual DbSet<BookAuthor> BookAuthors { get; set; }
    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<LocalIdentityUser> LocalIdentityUsers { get; set; }

    public virtual DbSet<WishListItem> WishListItems { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrdersItems { get; set; }

    public virtual DbSet<BookImage> BookImages { get; set; }

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

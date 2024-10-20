using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public class BookHubDBContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<User> Users { get; set; }

    public BookHubDBContext(DbContextOptions<BookHubDBContext> options)
        : base(options) { }

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

        base.OnModelCreating(modelBuilder);
    }
}

using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data;

public class BookHubDBContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public BookHubDBContext(DbContextOptions<BookHubDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.SetNull;
        }

        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }

}

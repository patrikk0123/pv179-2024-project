using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public static class DataInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var books = PrepareBookModels();

            modelBuilder.Entity<Book>().HasData(books);
        }

        private static List<Book> PrepareBookModels()
        {
            return new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Name = "Cesta do neznáma",
                    Description = "",
                    ISBN = "0-9742-0105-7",
                    PublishDate = new DateOnly(1990, 1, 2),
                    Pages = 120,
                    Rating = 4.0,
                    Price = 10.0,
                },
                new Book()
                {
                    Id = 2,
                    Name = "Hadí princezna a 102 psů",
                    Description = "",
                    ISBN = "0-5613-1830-1",
                    PublishDate = new DateOnly(2001, 3, 10),
                    Pages = 102,
                    Rating = 3.2,
                    Price = 30.0,
                },
            };
        }
    }
}

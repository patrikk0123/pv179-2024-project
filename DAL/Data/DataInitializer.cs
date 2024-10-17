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
                new Book() { Id = 1, Title = "Cesta do neznáma" },
                new Book() { Id = 2, Title = "Hadí princezna a 102 psů" },
            };
        }
    }
}

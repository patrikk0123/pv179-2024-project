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
            var publishers = PreparePublisherModels();
            var books = PrepareBookModels();
            var authors = PrepareAuthorModels();
            var bookAuthors = PrepareBookAuthorModels();

            modelBuilder.Entity<Publisher>().HasData(publishers);
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Author>().HasData(authors);
            modelBuilder.Entity<BookAuthor>().HasData(bookAuthors);
        }

        private static List<Publisher> PreparePublisherModels()
        {
            return new List<Publisher>()
            {
                new Publisher() { Id = 1, Name = "Booklord ABC" },
            };
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
                    PublisherId = 1,
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
                    PublisherId = 1,
                },
            };
        }

        private static List<Author> PrepareAuthorModels()
        {
            return new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Ronald",
                    Surname = "Kingson",
                },
                new Author()
                {
                    Id = 2,
                    Name = "Richard",
                    Surname = "Douchebag",
                },
                new Author()
                {
                    Id = 3,
                    Name = "William",
                    Surname = "Jerk",
                },
            };
        }

        private static List<BookAuthor> PrepareBookAuthorModels()
        {
            return new List<BookAuthor>()
            {
                new BookAuthor()
                {
                    Id = 1,
                    BookId = 1,
                    AuthorId = 1,
                },
                new BookAuthor()
                {
                    Id = 2,
                    BookId = 2,
                    AuthorId = 2,
                },
            };
        }
    }
}

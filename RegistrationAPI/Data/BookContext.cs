using RegistrationAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RegistrationAPI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using BookAPI.Models;

namespace RegistrationAPI.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        private ConnectionStrings _connectionStrings;

        // public BookContext(DbContextOptions<BookContext> options, IOptions<ConnectionStrings> connectionstrings) 
        // {
        //     _connectionStrings = connectionstrings.Value;
        // }
       
       public BookContext (DbContextOptions<BookContext> options, IOptions<ConnectionStrings> connectionstrings)
       {
            _connectionStrings = connectionstrings.Value;
       }


        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     options.UseSqlServer(_connectionStrings.SQL);
        // }
                protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author(){AuthorId = Guid.NewGuid(), Name = "Bill Gates", Age = 65, Country = "Unites States"});
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Matthew Walker", Age = 48, Country = "United Kingdom" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Hope Jahren", Age = 51, Country = "Unites States" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Matt Haig", Age = 45, Country = "United Kingdom" });
            modelBuilder.Entity<Author>().HasData(new Author() { AuthorId = Guid.NewGuid(), Name = "Lucy Foley", Age = 35, Country = "United Kingdom" });



            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Fiction" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Mystery & Thriller" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Nonfiction" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Science & Technology" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Historical Fiction" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Science & Technology" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Fantasy" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Romance" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre() { BookGenreId = Guid.NewGuid(), Genre = "Horror" });
        }
    }
}
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

        public BookContext(DbContextOptions<BookContext> options, IOptions<ConnectionStrings> connectionstrings) 
        {
            _connectionStrings = connectionstrings.Value;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }
    }
}
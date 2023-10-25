using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RegistrationAPI.Configuration;
using RegistrationAPI.Models;

namespace RegistrationAPI.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        private ConnectionStrings _connectionStrings;

        public BookContext(DbContextOptions<BookContext> options, IOptions<ConnectionStrings> connectionStrings) {
            _connectionStrings = connectionStrings.Value;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }
    }
}
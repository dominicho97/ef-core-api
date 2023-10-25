using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Models;

namespace RegistrationAPI.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

    }
}
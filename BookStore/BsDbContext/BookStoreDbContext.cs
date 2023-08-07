using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BsDbContext
{
    public class BookStoreDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) 
        { 

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BookStore;Username=postgres;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class AppDBContext  :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) :base(options)
        { 

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Language> Language { get; set; }
       
    }
}


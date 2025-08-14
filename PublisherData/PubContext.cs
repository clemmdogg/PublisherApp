using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{
    public class PubContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dataBaseName = "PallesXXX";
            optionsBuilder.UseSqlServer(
                $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={dataBaseName};Trusted_Connection=true;TrustServerCertificate=true");
        }
    }
}

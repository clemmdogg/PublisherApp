using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{
    public class PubContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public string DataBaseName { get; set; }

        public PubContext(string dataBaseName)
        {
            DataBaseName = dataBaseName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={DataBaseName};Trusted_Connection=true;TrustServerCertificate=true");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace GettingStarted
{
    internal class AppDbContext : DbContext
    {
        private const string ConnectionString = @"  Server=localhost,1433;
                                                    Database=ExampleDataBase;
                                                    User Id=sa;
                                                    Password=Selecttop10*from;
                                                    Trusted_Connection=false;
                                                    TrustServerCertificate=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

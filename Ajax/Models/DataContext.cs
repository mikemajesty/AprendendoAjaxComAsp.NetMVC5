
using System.Configuration;
using System.Data.Entity;


namespace Aprendendo.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DataContext() : 
            base(ConfigurationManager.ConnectionStrings["Con"].ConnectionString)
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable(nameof(Models.Cliente));
           
        }
    }
}
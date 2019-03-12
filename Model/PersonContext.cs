using Microsoft.EntityFrameworkCore;

namespace appiatech.Model
{
    public class PersonContext : DbContext
    {

        public DbSet<Person> Perons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }

    }
}
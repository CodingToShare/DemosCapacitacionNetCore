using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(e =>
            e.HasKey(x => x.Id)
            );

            modelBuilder.Entity<Person>().OwnsOne(o => o.Name, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Name");
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
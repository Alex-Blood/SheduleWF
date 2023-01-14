using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace SheduleWF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Weekday> Weekdays => Set<Weekday>();
        public DbSet<Lesson> Lessons => Set<Lesson>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Shedule.db");
        }
    }
}

using BL1.DbContext;
using Microsoft.EntityFrameworkCore;

namespace BL1.DbContext2
{
    public class AppDbContext1 : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-9FN8A8G\\SQLEXPRESS;Database=CarDb;Integrated Security=true;Trust Server Certificate=true;");
        }

        public DbSet<Car> Cars { get; set; }
    }
}

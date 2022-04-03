using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Data
{
    public class W2WDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Data Source=DESKTOP-P4IHDA9\\SQLEXPRESS; Initial Catalog=W2WDB;Persist Security Info=True;User ID=w2w;Password=w2w");
         }
    }
}

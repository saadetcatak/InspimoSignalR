using Microsoft.EntityFrameworkCore;

namespace InspimoSignalRAPİ.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SAADET\\SQLEXPRESS01;initial catalog=DbSignalR;integrated security=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}

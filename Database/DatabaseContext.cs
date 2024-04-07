using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DatabaseContext : DbContext
    {
        private const string CONNECTION_STRING = "Data Source=DESKTOP-G3R3SBD;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True";

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<CoworkingZone> CoworkingZones { get; set; } = null!;

        public DbSet<Employee> Employees { get; set; } = null!;

        public DbSet<Position> Positions { get; set; } = null!;

        public DbSet<Request> Requests { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Service> Services { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public DatabaseContext()
        {
            Database.EnsureDeleted();

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Title = "Администратор"
                },
                new Role
                {
                    Id = 2,
                    Title = "Менеджер"
                },
                new Role
                {
                    Id = 3,
                    Title = "Пользователь"
                });
        }
    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<HotelEntity> Hotels { get; set; }
    public DbSet<FloorEntity> Floors { get; set; }
    public DbSet<ApartmentEntity> Apartments { get; set; }
    public DbSet<ApartmentImage> ApartmentImages { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=app.db;");
        base.OnConfiguring(optionsBuilder);
    }
}
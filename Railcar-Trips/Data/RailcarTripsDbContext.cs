using Microsoft.EntityFrameworkCore;
using Railcar_Trips.Data.Models;

namespace Railcar_Trips.Data;

public class RailcarTripsDbContext : DbContext
{
    public RailcarTripsDbContext(DbContextOptions<RailcarTripsDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Event> Events { get; set; }
}

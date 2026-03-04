using Microsoft.EntityFrameworkCore;

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
}

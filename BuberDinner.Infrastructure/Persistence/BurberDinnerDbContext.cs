using BuberDinner.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure.Persistence;

public class BurberDinnerDbContext : DbContext
{
    public DbSet<Host> Hosts { get; set; }
    public DbSet<Dinner> Dinners { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BurberDinnerDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}

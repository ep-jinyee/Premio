using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Premio.Models;

public class PremioDbContext : IdentityDbContext<IdentityUser>
{
    public PremioDbContext(DbContextOptions<PremioDbContext> options) : base(options) { }
    public DbSet<Annoucement> Annoucements { get; set; }
    public DbSet<Premise> Premises { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<AccessRequest> AccessRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasOne(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<Profile>(p => p.UserId);

        modelBuilder.Entity<User>()
            .HasOne(a => a.Tenant)
            .WithOne(a => a.User)
            .HasForeignKey<Tenant>(t => t.UserId);

        base.OnModelCreating(modelBuilder);
    }
}
using Microsoft.EntityFrameworkCore;

public class PremioDbContext : DbContext
{
    public PremioDbContext(DbContextOptions<PremioDbContext> options) : base(options) { }


}
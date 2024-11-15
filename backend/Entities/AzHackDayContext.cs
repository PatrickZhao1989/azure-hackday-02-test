using Microsoft.EntityFrameworkCore;

public class AzHackDayContext(DbContextOptions<AzHackDayContext> options) : DbContext(options)
{

    // Define your DbSets (tables) here
    public DbSet<Product> Products { get; set; }
}
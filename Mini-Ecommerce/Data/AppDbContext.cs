using Microsoft.EntityFrameworkCore;

namespace Mini_Ecommerce.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}

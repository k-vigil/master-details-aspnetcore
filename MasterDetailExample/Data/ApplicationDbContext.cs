using MasterDetailExample.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailExample.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {

    }
}

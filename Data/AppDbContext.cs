using Microsoft.EntityFrameworkCore;
using UserRegistrationAPI.Models;

namespace UserRegistrationAPI.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users {get; set;}
}


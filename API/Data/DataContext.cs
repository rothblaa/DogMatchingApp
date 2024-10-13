using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

//primary constructor: instead of having constructor inside the class
public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }

}

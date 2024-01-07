
using Microsoft.EntityFrameworkCore;
using BookeyWebApp.Models;

namespace BookeyWebApp.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
}

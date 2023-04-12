using APIBookList.Models;
using Microsoft.EntityFrameworkCore;

namespace APIBookList.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Book> Books { get; set; }

}

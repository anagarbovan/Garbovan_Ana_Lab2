using Microsoft.EntityFrameworkCore;

public class Garbovan_Ana_Lab2Context(DbContextOptions<Garbovan_Ana_Lab2Context> options) : DbContext(options)
{
    public DbSet<Garbovan_Ana_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Garbovan_Ana_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Garbovan_Ana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
}

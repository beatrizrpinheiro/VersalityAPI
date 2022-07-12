using FilesAPI.Models;
using Microsoft.EntityFrameworkCore;

public class FilesContext : DbContext
{
    public FilesContext(DbContextOptions<FilesContext> options)
        : base(options)
    {
    }

    public DbSet<Termometro>? Termometro { get; set; }
    public DbSet<Aula>? Aula { get; set; }
}

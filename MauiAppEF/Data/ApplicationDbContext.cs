using Microsoft.EntityFrameworkCore;

namespace MauiAppEF.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }

    public DbSet<Grades> Grades { get; set; }

    public ApplicationDbContext()
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Maui;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}

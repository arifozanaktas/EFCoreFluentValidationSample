using Microsoft.EntityFrameworkCore;

namespace EFCoreFluentValidation.Models.ORM;

public class FluentValidationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DLOP8P5\SQLEXPRESS;Initial Catalog=EFCoreFluentValidation;Integrated Security=True;Trust Server Certificate=True");
    }
    public DbSet<Student> Students { get; set; }
}

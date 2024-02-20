using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvc_dotnet_jokepages.Models;

namespace mvc_dotnet_jokepages.Data;
public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<mvc_dotnet_jokepages.Models.Joke> Joke { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure the relationship
        modelBuilder.Entity<Joke>()
            .HasOne(j => j.User)
            .WithMany() // Assuming a user can have many jokes. Adjust if needed.
            .HasForeignKey(j => j.UserId);
    }
}

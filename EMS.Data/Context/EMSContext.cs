using EMS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Data.Contexts;
public class EMSContext(DbContextOptions<EMSContext> options) : DbContext(options)
{
    public DbSet<Country> InfoCountries { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<InfoContentType> ContentTypes { get; set; }
    public DbSet<InfoContent> InfoContents { get; set; }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
    }*/
}

using cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace cinema.Data;


public class CinemaContext : DbContext
{
  public CinemaContext()
  {

  }
  public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
  {

  }
  public DbSet<Movie> Movies { get; set; }
  public DbSet<Display> Displays { get; set; }
  public DbSet<Salon> Salons { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    modelBuilder.Entity<Movie>().HasData(
                          new Movie
                          {
                            Id = 1,
                            Title = "Jumanji"
                          },
                    new Movie
                    {
                      Id = 2,
                      Title = "Birds of Prey"
                    },
                    new Movie
                    {
                      Id = 3,
                      Title = "Frozen 2"
                    },
                    new Movie
                    {
                      Id = 4,
                      Title = "Mulan"
                    },
                    new Movie
                    {
                      Id = 5,
                      Title = "1917"
                    }
    );

    modelBuilder.Entity<Salon>().HasData(new Salon
    {
      Id = 1,
      Name = "Salon 1",
      Seats = 50
    },
                    new Salon
                    {
                      Id = 2,
                      Name = "Salon 2",
                      Seats = 100
                    }
                    );

    modelBuilder.Entity<Display>().HasData(
                          new Display
                          {
                            Id = 1,
                            MovieId = 1,
                            SalonId = 2,
                            Time = DateTime.Parse("21:30")
                          },
    new Display
    {
      Id = 2,
      MovieId = 2,
      SalonId = 1,
      Time = DateTime.Parse("13:00")
    },
    new Display
    {
      Id = 3,
      MovieId = 3,
      SalonId = 1,
      Time = DateTime.Parse("15:00")
    },
    new Display
    {
      Id = 4,
      MovieId = 4,
      SalonId = 2,
      Time = DateTime.Parse("19:00")
    },
    new Display
    {
      Id = 5,
      MovieId = 3,
      SalonId = 2,
      Time = DateTime.Parse("17:00")
    },
    new Display
    {
      Id = 6,
      MovieId = 5,
      SalonId = 1,
      Time = DateTime.Parse("17:00")
    }
    );

    modelBuilder.Entity<Display>()
    .HasOne(d => d.Movie)
    .WithMany(m => m.Displays).IsRequired();
    modelBuilder.Entity<Salon>()
        .HasMany(s => s.Displays)
        .WithOne(d => d.Salon).IsRequired();

  }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamOverCinema.Models;

namespace TeamOverCinema.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TeamOverCinema.Models.Events>? Events { get; set; }
        public DbSet<TeamOverCinema.Models.Movies>? Movies { get; set; }
        public DbSet<TeamOverCinema.Models.MovieTimes>? MovieTimes { get; set; }
    }
}
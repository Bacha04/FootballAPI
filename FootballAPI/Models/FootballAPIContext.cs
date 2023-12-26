using Microsoft.EntityFrameworkCore;

namespace FootballAPI.Models
{
    public class FootballAPIContext: DbContext 
    {
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        public FootballAPIContext(DbContextOptions<FootballAPIContext> options) 
            : base(options) 
        { 
        Database.EnsureCreated();
        }

    }
}

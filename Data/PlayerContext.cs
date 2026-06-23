using Microsoft.EntityFrameworkCore;
using YourPlayer.Models;

namespace YourPlayer.Data
{
    public class PlayerContext : DbContext
    {
        public DbSet<PlayerModel> Player {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=player.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mariia_S_301052981.Models
{
    public class EFPlayerRepository : IPlayerRepository
    {
        private ApplicationDbContext context;

        public EFPlayerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Player> Players => context.Players;

        public void Save(Player player)
        {
            if (!context.Players.Contains(player))
            {
                context.Players.Add(player);
            }
            else
            {
                Player dbEntry = context.Players
                .FirstOrDefault(p => p.PlayerName == player.PlayerName);
                if (dbEntry != null)
                {
                    dbEntry.PlayerName = player.PlayerName;
                    dbEntry.Age = player?.Age ?? 0;
                    dbEntry.CountryOfBirth = player?.CountryOfBirth ?? "None";
                    dbEntry.PlayingPosition = player?.PlayingPosition ?? "None";
                    dbEntry.ClubFullName = player.ClubFullName;
                }
            }
            context.SaveChanges();
        }
    }
}


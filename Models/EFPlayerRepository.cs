using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
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
            if (player.PlayerID == 0)
            {
                context.Players.Add(player);
            }
            else
            {
                Player dbEntry = context.Players
                .FirstOrDefault(p => p.PlayerID == player.PlayerID);
                if (dbEntry != null)
                {
                    dbEntry.PlayerName = player.PlayerName;
                    dbEntry.Age = player?.Age ?? 0;
                    dbEntry.CountryOfBirth = player.CountryOfBirth;
                    dbEntry.PlayingPosition = player.PlayingPosition;
                    //dbEntry.ClubFullName = player.ClubFullName; ???
                }
            }
            context.SaveChanges();
        }


        public Player DeletePlayer(int playerID)
        {
            Player dbEntry = context.Players
            .FirstOrDefault(p => p.PlayerID == playerID);
            if (dbEntry != null)
            {
    
                context.Players.Remove(dbEntry);
                context.SaveChanges();

            }
            return dbEntry;
        }
    }
}


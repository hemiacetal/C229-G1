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
                    dbEntry.CountryOfBirth = player?.CountryOfBirth;
                    dbEntry.PlayingPosition = player?.PlayingPosition;
                    //dbEntry.ClubFullName = player.ClubFullName;
                }
            }
            context.SaveChanges();
        }


        public Player DeletePlayer(string name)
        {
            Player dbEntry = context.Players
            .FirstOrDefault(p => p.PlayerName == name);
            if (dbEntry != null)
            {
                //context.Players.RemoveRange(context.Players.Where(p => p.ClubFullName == name));
                //context.Clubs.Remove(dbEntry);


                //context.Clubs.Remove(context.)
                //context.Players.RemoveRange(context.Players.Where(p => p.ClubFullName == name));
                context.Players.Remove(dbEntry);
                context.SaveChanges();

            }
            return dbEntry;
        }
    }
}


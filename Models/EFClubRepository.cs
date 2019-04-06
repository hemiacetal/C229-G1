using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mariia_S_301052981.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context; 

        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Club> Clubs => context.Clubs.Include(c => c.Players);


        public void Save(Club club)
        {
            if (!context.Clubs.Contains(club))
            {
                context.Clubs.Add(club);
            }
            else
            {
                Club dbEntry = context.Clubs
                .FirstOrDefault(c => c.ClubFullName == club.ClubFullName);
                if (dbEntry != null)
                {
                    dbEntry.ClubFullName = club.ClubFullName;

                    dbEntry.Country = club.Country;
                    dbEntry.HeadCoachName = club.HeadCoachName;
                    dbEntry.Ground = club.Ground;

                    //dbEntry.Country = club?.Country ?? "None";
                    //dbEntry.HeadCoachName = club?.HeadCoachName ?? "None";
                    //dbEntry.Ground = club?.Ground ?? "None";

                }
            }
            context.SaveChanges();
        }


        public Club DeleteClub(string name)
        {
            Club dbEntry = context.Clubs
            .FirstOrDefault(c => c.ClubFullName == name);
            if (dbEntry != null)
            {

                context.Players.RemoveRange(context.Players.Where(p => p.ClubFullName == name));
                context.Clubs.Remove(dbEntry);
                context.SaveChanges();

            }
            return dbEntry;
        }


    }
}

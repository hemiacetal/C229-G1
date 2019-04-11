using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
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
            if (club.ClubID == 0)
            {
                context.Clubs.Add(club);
            }
            else
            {
                Club dbEntry = context.Clubs
                .FirstOrDefault(c => c.ClubID == club.ClubID);
                if (dbEntry != null)
                {
                    dbEntry.ClubFullName = club.ClubFullName;

                    dbEntry.Country = club.Country;
                    dbEntry.HeadCoachName = club.HeadCoachName;
                    dbEntry.Ground = club.Ground;
                    //dbEntry.Players = club.Players;
                }
            }
            context.SaveChanges();
        }


        public Club DeleteClub(int clubID)
        {
            Club dbEntry = context.Clubs
            .FirstOrDefault(c => c.ClubID == clubID);
            if (dbEntry != null)
            {

                context.Players.RemoveRange(context.Players.Where(p => p.ClubID == clubID));
                context.Clubs.Remove(dbEntry);
                context.SaveChanges();

            }
            return dbEntry;
        }


    }
}

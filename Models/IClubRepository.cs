using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mariia_S_301052981.Models
{
    public interface IClubRepository
    {
        IQueryable<Club> Clubs { get; }
        void Save(Club club);
        Club DeleteClub(string name);

    }
}

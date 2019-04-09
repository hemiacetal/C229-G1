﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mariia_S_301052981.Models
{
    public interface IPlayerRepository
    {
        IQueryable<Player> Players { get; }
        void Save(Player player);
        Player DeletePlayer(string name);
    }
}

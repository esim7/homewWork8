using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Team : Entity
    {
        public string Name { get; set; } // название команды
        public string CoachName { get; set; } // тренер
        public string BaseCity { get; set; }
        public virtual List<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }
    }
}

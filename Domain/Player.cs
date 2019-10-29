using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Player : Entity
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public int Wage { get; set; }

        public Guid/*?*/ TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Archer :Klassen
    {
        public Archer(double max_Health, double health_Points, double damage_Dealt)
        {
            Max_Health = max_Health;
            Health_Points = health_Points;
            Damage_Dealt = damage_Dealt;
        }

    }
}

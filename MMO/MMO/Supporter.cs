using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Supporter :Klassen
    {
        public double Heal_Amount { get; set; }

        public Supporter(double max_Health, double health_Points, double damage_Dealt, double heal_Amount)
        {
            Max_Health = max_Health;
            Health_Points = health_Points;
            Damage_Dealt = damage_Dealt;
            Heal_Amount = heal_Amount;
        }
        
    }
}

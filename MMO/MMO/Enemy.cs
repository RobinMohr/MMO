using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Enemy
    {
        public double Enemy_Max_HP { get; set; }
        public double Enemy_Health_Points { get; set; }
        public double Enemy_Damage_Dealt { get; set; }


        public Enemy(double enemy_Max_HP, double enemy_Health_Points, double damage_Dealt)
        {
            Enemy_Max_HP = enemy_Max_HP;
            Enemy_Health_Points = enemy_Health_Points;
            Enemy_Damage_Dealt = damage_Dealt;
        }
        public void Enemy_Damage_Taken()
        {

        }
    }
}

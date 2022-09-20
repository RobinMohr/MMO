using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Enemy
    {
        public bool Enemy_Alive = false;
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
        public void Enemy_Spawning()
        {
            Random random = new Random();
            int x = random.Next(0,7);
            if (Enemy_Alive == false)
            {
                if (x == 0)
                {
                    Console.WriteLine("Diese Runde spawnt kein Gegner, du kannst dich ausruhen und dich Heilen.");
                }

                Enemy_Alive = true;

                if (x == 1)
                {
                    Console.WriteLine("Ein Goblin greift dich aus dem Hinterhalt and.");
                    Enemy_Max_HP = 40;
                    Enemy_Health_Points = 40;
                    Enemy_Damage_Dealt = 5;



                }



            }
                        
        }   
    }
}

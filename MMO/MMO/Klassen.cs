using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public abstract class Klassen
    {
        public double Max_Health { get; set; }
        public double Health_Points { get; set; }
        public double Damage_Dealt { get; set; }

        public interface IClass
        {
            void Dealing_Damage();
            void Recieving_Damage();
            void Recieving_Heal();
        }

        public void Dealig_Damage()
        {
            Console.WriteLine($"you have dealt {Damage_Dealt}  damage to the enemy");
            
            
        }
    }
}

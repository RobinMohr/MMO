using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Melee m = new Melee(40, 40, 10);
            Supporter s = new Supporter(30, 30, 6, 6);
            Archer a = new Archer(30, 30, 15);
            Tank t = new Tank(50, 50, 8);
            Enemy e = new Enemy(30, 30, 5);

            
            bool spiel = true;

            List<Klassen> c = new List<Klassen>();

            c.Add(m);
            c.Add(s);
            c.Add(a);
            c.Add(t);

            Console.WriteLine("Welche Klasse möchtest du Spielen?(0Melee,1Support,2Archer,3Tank)");
            int i = Int32.Parse(Console.ReadLine());



            do
            {
                




            }while(spiel);


            Console.ReadKey();
        }
    }
}

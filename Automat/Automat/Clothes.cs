using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    // Kallar abstraktklassen samt interface
    internal class Clothes : Item, iMethods
    {

        //Skapa en ny lista med standardkapacitet
        public static List<Clothes> kläder = new List<Clothes>();


        // Kallar konstruktorn från Item/basklassen
        public Clothes(string name, string description, int price) : base(name, description, price)
        {


        }

        //Kallar metoderna från interfacen
        public void Use()
        {
            Console.WriteLine("Hope you engoy the feeling of warmth!");

        }
        public void Buy()
        {

            Console.WriteLine($"Now you bought your item");

        }

        public void Description(int desRäknare)
        {

            Console.WriteLine($"{desRäknare}. {name}, {description}, and it costs {49} kr ");

        }

    }
}

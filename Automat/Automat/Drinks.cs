using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    // Kallar abstraktklassen samt interface
    internal class Drinks : Item, iMethods

    {
        //Skapa en ny lista med standardkapacitet
        public static List<Drinks> drinks = new List<Drinks>();

        //Deklarerar en ny attribut som tillhör endast denna klass
        public string taste;

        // Kallar konstruktorn från Item/basklassen
        public Drinks(string name, string description, int price, string taste) : base(name, description, price)
        {

            this.taste = taste;
        }

        //Kallar metoderna från interfacen
        public void Use()
        {
            Console.WriteLine("Hope you enjoy it!");

        }
        public void Buy()
        {

            Console.WriteLine($"Now you bought your drink");

        }

        public void Description(int desRäknare)
        {

            Console.WriteLine($"{desRäknare}. {name}, {description}, and it costs {15} kr, taste {taste}");

        }



    }
}

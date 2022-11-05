using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    // Kallar abstraktklassen samt interface
    internal class ProteinBars : Item, iMethods


    {
        //Skapa en ny lista med standardkapacitet
        public static List<ProteinBars> proteinBars = new List<ProteinBars>();

        //Deklarerar en ny attribut som tillhör endast denna klass
        public string taste;

        // Kallar konstruktorn från Item/basklassen
        public ProteinBars(string name, string description, int price, string taste) : base(name, description, price)
        {
            
            this.taste = taste;
        }

        //Kallar metoderna från interfacen
        public void Use()
        {
            Console.WriteLine("Hope you will be filled with energy!");

        }
        public void Buy()
        {

            Console.WriteLine($"Now you bought your bar");

        }

        public void Description(int desRäknare)
        {

            Console.WriteLine($"{desRäknare}. {name}, {description}, and it costs {29} kr, taste {taste}");

        }
             
    }
}

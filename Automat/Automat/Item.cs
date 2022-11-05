using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    //Skapa en abstraktklass Item som alla andra klasser ärver ifrån
    internal class Item
    {
        // Attribut som beskriver utseendet för objekten i klasserna
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }

        // Konstruktor
        public Item(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}

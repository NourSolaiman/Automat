using System.Security.Cryptography.X509Certificates;

namespace Automat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar nya objekt i klasserna som även kallar den abstrakta klassen Item

            Drinks.drinks.Add(new Drinks("Cola", "Utan socker (zero)", 15, " (olika citrus-aromer)"));
            Drinks.drinks.Add(new Drinks("Redbull", "Ger dig vingar", 15, "(söt smak med en ganska syrlig finish)"));
            Drinks.drinks.Add(new Drinks("Sprite", "kolsyrad läskedryck", 15, "(citron- och limesmakr)"));
            Clothes.kläder.Add(new Clothes("Gloves", "Värmer dina händer", 49));
            Clothes.kläder.Add(new Clothes("Scarf", "Värmer runtomkring halsen", 49));
            Clothes.kläder.Add(new Clothes("Stocking cap", "Värmer ditt huvud", 49));
            ProteinBars.proteinBars.Add(new ProteinBars("Optimum Protein", "20g protein och 2g sockerarter per bar", 29, "Chocolate Caramel"));
            ProteinBars.proteinBars.Add(new ProteinBars("Barebells Protein", "23g protein utan tillsatt socker", 29, "White Chocolate Almond"));
            ProteinBars.proteinBars.Add(new ProteinBars("Topformula Protein", "25g protein utan tillsatt socker", 29, "Salty Peanut"));

            menu();

            // Skapar en ny metod som innehåller menyvalen
            void menu()
            {
                bool appRunning = true;

                //Skapa Do While-Loop för att lopa igenom menyvalen
                do
                {
                    int input = 0;
                    Console.WriteLine("Welcome to our store, we are happy for your visit!");
                    Console.WriteLine("Make a choise with numbers, please!");
                    Console.WriteLine();
                    Console.WriteLine("*******************");
                    Console.WriteLine("* 1. Drinks       *");
                    Console.WriteLine("* 2. Clothes      *");
                    Console.WriteLine("* 3. Protein Bars *");
                    Console.WriteLine("* 4. End          *");
                    Console.WriteLine("*******************");
                    // Lägger till try-catch som undantag i fall kunden trycker på fel knapp
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Fel input använd endast siffror.");

                    }

                    // För att rensa den före detta outputen
                    Console.Clear();

                    if (input == 1)
                    {
                        while (true)
                        {
                            //Kallar metoden från Drinks-klassen via foreach
                            int desRäknare = 1;
                            foreach (Drinks drinks in Drinks.drinks)
                            {

                                Console.Write("Choose "); drinks.Description(desRäknare);
                                desRäknare++;


                            }

                            Console.WriteLine();
                            Console.WriteLine("Make a choise with numbers 1, 2 or 3 if you want to confirm your purchase, please!");
                            int räknare1 = 0;

                            // Lägger till try-catch som undantag i fall kunden trycker på fel knapp
                            try
                            {
                                räknare1 = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception e)
                            {


                                Console.WriteLine(e.Message, "Wrong input, Make a choise with numbers 1, 2 or 3, please!");

                            }
                            // För att rensa den före detta outputen
                            Console.Clear();

                            // För att loopa igenom objekten i listan.
                            foreach (Drinks drinks in Drinks.drinks)
                            {
                                if (räknare1 == 1)
                                {
                                    Console.WriteLine("You choose a Cola Zero, 15 kr will be deducted from your balance");
                                    drinks.Buy();
                                    drinks.Use();
                                }
                                else if (räknare1 == 2)
                                {
                                    Console.WriteLine("You choose a Redbull, 15 kr will be deducted from your balance");
                                    drinks.Buy();
                                    drinks.Use();
                                }
                                else if (räknare1 == 3)
                                {
                                    Console.WriteLine("You choose a Sprite, 15 kr will be deducted from your balance");
                                    drinks.Buy();
                                    drinks.Use();
                                }

                                else
                                {
                                    Console.WriteLine("Make a choise with numbers 1, 2 or 3, please!");
                                    Console.Clear();
                                    Console.WriteLine("Wrong input, press any key to contiue!");
                                    Console.ReadKey();
                                    //tillbaka-funktion till menyvalen
                                    menu();
                                }
                                return;
                            }


                        }

                    }

                    // För att rensa den före detta outputen
                    Console.Clear();

                    if (input == 2)
                    {
                        while (true)
                        {
                            //Kallar metoden från Drinks-klassen via foreach
                            int räknare = 1;

                            // För att loopa igenom objekten i listan.
                            foreach (Clothes clothes in Clothes.kläder)
                            {

                                Console.Write("Choose "); clothes.Description(räknare);
                                räknare++;


                            }

                            Console.WriteLine();
                            Console.WriteLine("Make a choise with numbers 1, 2 or 3 if you want to confirm your purchase, please!");
                            int räknare1 = 0;

                            // Lägger till try-catch som undantag i fall kunden trycker på fel knapp
                            try
                            {
                                räknare1 = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message, "Fel input använd endast siffror.");

                            }
                            // För att rensa den före detta outputen
                            Console.Clear();

                            // För att loopa igenom objekten i listan.
                            foreach (Clothes clothes in Clothes.kläder)
                            {
                                if (räknare1 == 1)
                                {
                                    Console.WriteLine("You choose a Gloves, 49 kr will be deducted from your balance");
                                    clothes.Buy();
                                    clothes.Use();

                                }
                                else if (räknare1 == 2)
                                {
                                    Console.WriteLine("You choose a Scarf, 49 kr will be deducted from your balance");
                                    clothes.Buy();
                                    clothes.Use();
                                }
                                else if (räknare1 == 3)
                                {
                                    Console.WriteLine("You choose a Stocking Cap, 49 kr will be deducted from your balance");
                                    clothes.Buy();
                                    clothes.Use();
                                }
                                else
                                {
                                    Console.WriteLine("Make a choise with numbers 1, 2 or 3, please!");
                                    Console.Clear();
                                    Console.WriteLine("Wrong input, press any key to contiue!");
                                    Console.ReadKey();
                                    //tillbaka-funktion till menyvalen
                                    menu();
                                }
                                return;
                            }

                        }

                    }

                    // För att rensa den före detta outputen
                    Console.Clear();

                    if (input == 3)
                    {
                        while (true)
                        {
                            //Kallar metoden från Drinks-klassen via foreach
                            int räknare = 1;
                            foreach (ProteinBars proteinBars in ProteinBars.proteinBars)
                            {

                                Console.Write("Choose "); proteinBars.Description(räknare);
                                räknare++;


                            }

                            Console.WriteLine();
                            Console.WriteLine("Make a choise with numbers 1, 2 or 3 if you want to confirm your purchase, please!");
                            int räknare1 = 0;
                            // Lägger till try-catch som undantag i fall kunden trycker på fel knapp
                            try
                            {
                                räknare1 = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message, "Fel input använd endast siffror.");
                                
                            }
                            // För att rensa den före detta outputen
                            Console.Clear();

                            // För att loopa igenom objekten i listan.
                            foreach (ProteinBars proteinBars in ProteinBars.proteinBars)
                            {
                                if (räknare1 == 1)
                                {
                                    Console.WriteLine("You choose a Optimum Protein, 29 kr will be deducted from your balance");
                                    proteinBars.Buy();
                                    proteinBars.Use();
                                }
                                else if (räknare1 == 2)
                                {
                                    Console.WriteLine("You choose a Barebells Protein, 29 kr will be deducted from your balance");
                                    proteinBars.Buy();
                                    proteinBars.Use();
                                }
                                else if (räknare1 == 3)
                                {

                                    Console.WriteLine("You choose a Topformula Protein, 29 kr will be deducted from your balance");
                                    proteinBars.Buy();
                                    proteinBars.Use();
                                }
                                else
                                {
                                    Console.WriteLine("Make a choise with numbers 1, 2 or 3, please!");
                                    Console.Clear();
                                    Console.WriteLine("Wrong input, press any key to contiue!");
                                    Console.ReadKey();
                                    //tillbaka-funktion till menyvalen
                                    menu();
                                }
                                return;
                            }

                        }
                    }


                    // För att avsluta programmet i fall kunden ångrar köpet
                    if (input == 4)
                    {
                        appRunning = false;

                    }

                  // För att fortsätta lopa igenom menyvalen efter Do   
                } while (appRunning);

            }
        }
    }

}

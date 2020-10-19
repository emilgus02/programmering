using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Marknad
{
    class Program
    {

        public static List<Kund> _kund = new List<Kund>();
        public static List<Produkt> _klockor = new List<Produkt>();
        public static List<string> _cart = new List<string>();
        public static List<int> _min = new List<int>();
        public static List<int> _max = new List<int>();

        static void Main(string[] args)
        {
            _klockor.Add(new Produkt("tommyhilfiger", 1595)); // lägger in dem klockor som man kan köpa
            _klockor.Add(new Produkt("boss", 3295));
            _klockor.Add(new Produkt("versace", 7445));
            _klockor.Add(new Produkt("michealkors", 3645));
            _klockor.Add(new Produkt("rolex", 135595));

            Console.WriteLine("Hej välkommen till Klockhuset!");

            Mainmeny(); // kallar menyn
        }

        private static void Mainmeny()
        {
            bool menu = true;
            do
            {
                Console.WriteLine("Vad vill du göra");
                Console.WriteLine("Logga in? (1)");
                Console.WriteLine("Skapa ett konto (2)");
                Console.WriteLine("Avsluta (3)");

                switch (Console.ReadLine()) // kollar vad personen vill göra
                {
                    case "1":
                        Loggain();
                        break;

                    case "2":
                        newc();
                        break;

                    case "3":
                        Console.WriteLine("Ha en bra dag!");
                        System.Environment.Exit(1);
                        break;
                }
            } while (menu == true);

        }

        private static int newc()
        {
            int newCN = 0;
            Console.WriteLine("Vad heter du?");

            string namn = Console.ReadLine(); // personen väljer sitt namn
            namn.ToUpper();

            Console.WriteLine("Hur gammmal är du?");

            int alder = int.Parse(Console.ReadLine()); // personen väljer sin ålder
            _kund.Add(new Kund(namn, alder)); //lägger in namnet och åldern i listan

            Console.WriteLine("Du har nu gjort ett konto");
            Console.WriteLine();
            newCN = newCN + 1;

            return newCN;
        }

        static void Loggain()
        {
            int nummer;
            Console.WriteLine("För att vi ska veta vem du är så behöver vi veta ditt namn och ålder");
            Console.WriteLine("Vad är ditt namn?");
            string logName = Console.ReadLine();
            Console.WriteLine("Vad är din ålder?");
            int logYear = int.Parse(Console.ReadLine());
            logName.ToUpper();

            for (int i = 0; i < _kund.Count; i++)
            {
                if (_kund[i].name == logName) //kollar att namnet existerar i listan
                {
                    if (_kund[i].year == logYear) //kollar att åldern existerar i listan
                    {
                        Console.WriteLine("Hej " + logName);
                        nummer = i; // ger personen en siffra
                        account(nummer);
                    }
                }
            }
        }

        private static void account(int nummer)
        {
            bool menu = true;

                    klockor();

            
            do
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("Köpa mer klockor (1)");
                Console.WriteLine("Kassa (2)");
                Console.WriteLine("Logga ut (3)");

                switch (Console.ReadLine())
                {
                    case "1":
                        clocks(nummer);
                        break;

                    case "2":
                        cartM(nummer);
                        break;

                    case "3":
                        menu = false;
                        break;
                }
            } while (menu == true);
        }

        private static void clocks(int nummer)
        {
            bool playAgain = true;
            bool againAgain = true;
            do
            {
                Console.WriteLine("Vilken klocka vill du köpa?");
                for (int i = 0; i < _klockor.Count; i++)
                {
                    Console.WriteLine(_klockor[i].name + " " + _klockor[i].price + " sek"); // berättar vilka klockor som finss
                }
                string adding = Console.ReadLine(); //väljer vilken klocka man vill ha
                adding.ToLower();

                for (int t = 0; t < _klockor.Count; t++)
                {
                    if (adding == _klockor[t].name) //kollar om klockan existerar
                    {
                        _cart.Insert(_min[nummer], adding); //lägger in klockan i korgen
                        for (int i = _min[nummer]; i < _max.Count; i++)
                        {
                            _max[i] = _max[i] + 1; // gör så att klockan syns i korgen
                        }
                    }
                }
                Console.WriteLine("Vill du lägga till en annan klocka? ja (1), nej (2)");
                do
                {
                    string again = Console.ReadLine(); // kollar om personen vill ´köra igen
                    if (again == "1")
                    {
                        againAgain = false;
                    }
                    else if (again == "2")
                    {
                        playAgain = false;
                        againAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Skriv 1 om du vill lägga till igen eller 2 om du inte vill");
                    }
                } while (againAgain == true);
            } while (playAgain == true);
        }

        private static void cartM(int nummer)   
        {
            Console.WriteLine();
            int pay = 0;
            Console.WriteLine("Dessa är produkterna som finns in din kassa");
            if (nummer == 0) // kollar om det är första personen som kör
            {
                for (int i = _min[nummer]; i < _max[nummer]; i++)
                {
                    if (!(_cart[i] == "")) //tar bort dem tomma ruterna
                    {
                        Console.WriteLine(_cart[i]); //skriver ut vad man har i korgen
                    }

                }
            } else
            {
                for (int i = _min[nummer] + 1; i < _max[nummer]; i++)
                {
                    if (!(_cart[i] == ""))
                    {
                        Console.WriteLine(_cart[i]); // skriver ut vad man har i korgen
                    }
                }
            }

            if (nummer == 0) // kollar om det är första personen som kör
            {
                for (int i = _min[nummer]; i < _max[nummer]; i++)
                {
                    for (int t = 0; t < _klockor.Count; t++)
                    {
                        if (_cart[i] == _klockor[t].name) // kollar vad klockorna har för summa
                        {
                            int _pay = _klockor[t].price + pay; // skriver ut den totala summan på klockorna fast för den första personen
                            pay = _pay;

                        }
                    }
                }
            }
            else
            {
                for (int i = _min[nummer] + 1; i < _max[nummer]; i++)
                {
                    for (int t = 0; t < _klockor.Count; t++)
                    {
                        if (_cart[i] == _klockor[t].name)
                        {
                            int _pay = _klockor[t].price + pay; // gör samma sak här
                            pay = _pay;

                        }
                    }
                }
            }
            Console.WriteLine("Den totala kostnaden är " + pay);
            Console.WriteLine();
            bool again = true;
            do
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("Vill du köpa dina klockor? (1)");
                Console.WriteLine("Vil du ta bort någon av klockorna? (2)");
                Console.WriteLine("Vill du gå tillbaks så du kan köpa mer klockor eller logga ut? (3)");

                switch (Console.ReadLine())
                {
                    case "1":
                        again = false;
                        buy(pay, nummer);
                        break;

                    case "2":
                        remove(nummer);
                        break;

                    case "3":
                        again = false;
                        break;
                }

            } while (again == true);
        }

        private static void remove(int nummer) 
        {
            bool again;
            do
            {
                again = true;
                Console.WriteLine();
                Console.WriteLine("Vilken av dessa klockor vill du ta bort?");
                if (nummer == 0) // kollar om det är första personen
                {
                    for (int i = _min[nummer]; i < _max[nummer]; i++)
                    {
                        if (!(_cart[i] == ""))
                        {
                            Console.WriteLine(_cart[i]);// visar vilka klockor man har i korgen
                        }
                    }

                    string rem = Console.ReadLine(); // väljer vilken klocka man vil ta bort
                    for (int i = _min[nummer]; i < _max[nummer]; i++)
                    {

                        if (_cart[i] == rem) // kollar att klockan finns i korgen
                        {
                                _cart[i] = ""; // tar bort den klockan man har valt
                                Console.WriteLine("Du har nu tagit bort " + rem);
                                i = _max[nummer]; // gör så att loopen inte forsätter
                        }
                    }

                }
                else // gör samma sak som finns i if över 
                {
                    for (int i = _min[nummer]; i < _max[nummer]; i++)
                    {
                        Console.WriteLine(_cart[i]);
                    }
                    string rem = Console.ReadLine();
                    for (int i = _min[nummer] + 1; i < _max[nummer]; i++)
                    {

                        if (_cart[i] == rem)
                        {
                            _cart[i] = "";
                            Console.WriteLine("Du har nu tagit bort " + rem);
                            i = _max[nummer];
                        }
                    }
                }
            } while (again == false);
        }

        private static void buy(int pay, int nummer)// köper klockan
        {
            Console.WriteLine(nummer);
            Console.WriteLine("Du har nu köpt ");
            for (int i = _min[nummer]; i < _max[nummer]; i++)
            {
                Console.WriteLine(_cart[i]);
            }
            Console.WriteLine("Kostnaden är " +  pay +  " det kommer att vara leverat till dig inom 3 dagar"); // visar summan man ska betala
            for (int i = 0; i < length; i++)
            {

                    _cart[i] = "";
                    i = _max[nummer];

            }

        }

        private static void klockor() // är första platsen man köper klockor på
        {
            bool playAgain = false;
            bool againAgain = true;

            do
            {
                Console.WriteLine("Vilken klocka vill du köpa?");
            for (int i = 0; i < _klockor.Count; i++)
            {
                Console.WriteLine(_klockor[i].name + " " + _klockor[i].price + " sek"); // visar klockorna och deras kostnad
            }
                Console.WriteLine("Om du inte vill ha en klocka tryck (3)");
                string adding = Console.ReadLine();
                adding.ToLower();
                if (!(adding == "3"))
                {
                    playAgain = true;
                    _min.Add(_cart.Count); // kollar vilken plats den första klockan ligger på listan

                    for (int t = 0; t < _klockor.Count; t++)
                    {
                        if (adding == _klockor[t].name) // kollar att klockan existerar
                        {
                            _cart.Add(adding);//lägger till klockan på lista
                        }
                    }

                    Console.WriteLine("Vill du lägga till en annan klocka? ja (1) nej (2)");
                    do
                    {
                        string again = Console.ReadLine(); // kollar om man vill köra igen
                        if (again == "1")
                        {
                            againAgain = false;
                        }
                        else if (again == "2")
                        {
                            playAgain = false;
                            againAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("Skriv 1 om du vill lägga till igen eller 2 om du inte vill");
                        }

                    } while (againAgain == true);
                }
            } while (playAgain == true) ;
            _max.Add(_cart.Count); //kollar vart den sista klockan är

        }
    }
}

    
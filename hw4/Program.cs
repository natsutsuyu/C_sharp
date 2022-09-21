using System;
namespace info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Azerbaijan.Baku aze = new Azerbaijan.Baku(2236000);
            USA.Washington usa = new USA.Washington(701974);
            Russia.Moscow rus = new Russia.Moscow(11920000);
            Console.WriteLine("Baku-" + aze.bakupopulation);
            Console.WriteLine("Washington-" + usa.washingtonpopulation);
            Console.WriteLine("Russia-" + rus.moscowpopulation);
            void compare()
            {
                int compareNum;
                int res = 0;
                Console.WriteLine($"Choose:\n1.Compare Baku with Moscow\n2.Compare Baku with Washington\n3.Compare Washington with Moscow: ");
                compareNum = Convert.ToInt32(Console.ReadLine());
                switch (compareNum)
                {
                    case 1:
                        res = rus.moscowpopulation - aze.bakupopulation;
                        Console.WriteLine("There are " + res + " more population in Moscow than in Baku.");
                        break;
                    case 2:
                        res = aze.bakupopulation - usa.washingtonpopulation;
                        Console.WriteLine("There are " + res + " more population in Baku than in Washington.");
                        break;
                    case 3:
                        res = rus.moscowpopulation - usa.washingtonpopulation;
                        Console.WriteLine("There are " + res + " more population in Moscow than in Washington.");
                        break;
                }
            }
            compare();
        }
    }
}



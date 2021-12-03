using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda
{
    class Robbery
    {
        public static void Main()
        {
            bool rat = false;

            Console.Write("Наличие полицейского(нет): ");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "y":
                case "yes":
                case "да":
                    rat = true;
                    break;
                case "0":
                case "n":
                case "no":
                case "нет":
                    rat = false;
                    break;
            }
            

            Ringleader ringleader = new Ringleader();

            Porter porter = new Porter(ringleader, rat);
            ringleader.AddToBand(porter);

            Cracker cracker = new Cracker(ringleader);
            ringleader.AddToBand(cracker);

            Driver driver = new Driver(ringleader);
            ringleader.AddToBand(driver);

            Console.WriteLine();
            ringleader.Planning();


            Console.ReadKey();
        }
    }
}

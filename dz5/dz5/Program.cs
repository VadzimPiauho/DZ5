using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    class Program
    {
        public delegate void busCarDelegate();
        static void Main(string[] args)
        {
            Games games = new Games();

            Console.WriteLine(games.busCar.carName);

            busCarDelegate d1 = games.busCar.printSpeed;
        }
    }
}

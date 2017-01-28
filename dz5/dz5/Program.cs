using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz5
{
    public delegate void CarDelegate(Random rand);
    public delegate void printNameDelegate();

    
    class Program
    {
        

        static void Main(string[] args)
        {
            Random rand = new Random();
            Games games = new Games();
           
            CarDelegate d1 = games.busCar.drive;
            d1 += games.cargoCar.drive;
            d1 += games.passengerCar.drive;
            d1 += games.sportCar.drive;
            printNameDelegate d2 = games.busCar.printSpeed;
            d2 += games.cargoCar.printSpeed;
            d2 += games.passengerCar.printSpeed;
            d2 += games.sportCar.printSpeed;

            //Console.WriteLine(games.busCar.carName);
            d2();
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("*******************************");
                d1(rand);
                d2();
            }
           

        }
        //static void TestDelegat(busCarDelegate metod)
        //{
        //     metod();
        //}
    }
}

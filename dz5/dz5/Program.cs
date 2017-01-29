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
            bool game = true;
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
            //games.busCar.finish += new EventHandler(FinishGames);
            games.busCar.finish += delegate (object sender, EventArgs e)
            {
                //game = false;
                Console.WriteLine("Автобус победил !\n");
                d2 -= games.busCar.printSpeed;
            };
            games.passengerCar.finish += delegate (object sender, EventArgs e)
            {
                //game = false;
                Console.WriteLine("Легковой победил !\n");
                d2 -= games.passengerCar.printSpeed;
            };
            games.cargoCar.finish += delegate (object sender, EventArgs e)
            {
                //game = false;
                Console.WriteLine("Грузовой победил !\n");
                d2 -= games.cargoCar.printSpeed;
            };
            games.sportCar.finish += delegate (object sender, EventArgs e)
            {
                //game = false;
                Console.WriteLine("Спортивный победил !\n");
                d2 -= games.sportCar.printSpeed;
            };

           

            //Console.WriteLine(games.busCar.carName);
            d2();
            while (game)
            {
               
                Thread.Sleep(1000);
                Console.WriteLine("*******************************");
                d1(rand);
                d2();
            }
           

        }

        //static void FinishGames(object sender, EventArgs e)
        //{
        //    game = false;
        //    Console.WriteLine("Работа.msadkjbajgjsbdнена !\n");
        //}
        //static void TestDelegat(busCarDelegate metod)
        //{
        //     metod();
        //}
    }
}

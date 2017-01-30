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
            bool gameON = true;
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
            d2();
            games.busCar.onCount += games.busCar.Message;
            games.cargoCar.onCount += games.cargoCar.Message;
            games.passengerCar.onCount += games.passengerCar.Message;
            games.sportCar.onCount += games.sportCar.Message;
            games.Game(ref d1,d2,rand, ref gameON, games);
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

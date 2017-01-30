using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz5
{
    public class Games
    {
        public SportCar sportCar { get; set; }
        public passengerCar passengerCar { get; set; }
        public cargoCar cargoCar { get; set; }
        public busCar busCar { get; set; }
        public Games()
        {
             sportCar = new SportCar("Спортивный");
             passengerCar = new passengerCar("Легковой");
             cargoCar = new cargoCar("Грузовой");
             busCar = new busCar("Автобус");
        }
        public void Game(CarDelegate d1, printNameDelegate d2,Random rand, ref bool gameON, Games games)
        {
            while (gameON)
            {
                if (games.busCar.distance==100&& games.cargoCar.distance == 100 && games.passengerCar.distance == 100 && games.sportCar.distance == 100)
                {
                    gameON = false;
                    return;
                }
                Thread.Sleep(1000);
                Console.WriteLine("*******************************");
                d1(rand);
                d2();
            }
        }
    }
}

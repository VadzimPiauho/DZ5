using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    class Games
    {
        public SportCar sportCar { get; set; }
        public passengerCar passengerCar { get; set; }
        public cargoCar cargoCar { get; set; }
        public busCar busCar { get; set; }

        public Games()
        {
            SportCar sportCar = new SportCar("Спортивный");
            passengerCar passengerCar = new passengerCar("Легковой");
            cargoCar cargoCar = new cargoCar("Грузовой");
            busCar busCar = new busCar("Автобус");
        }

    }
}

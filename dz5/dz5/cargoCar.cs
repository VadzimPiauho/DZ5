using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{

    public class cargoCar: Car
    {
        public event EventHandler finish;
        public cargoCar(string carName) : base(carName)
        {
            this.distance = 0;
        }
        public override void drive(Random rand)
        {
            distance += rand.Next(1, 10);
            if (distance >= 100)
            {
              distance = 100;
                onCountMetod();
            }
        }
        public override void Message()
        {
            Console.WriteLine("Грузовой финишировал");
        }
    }
}

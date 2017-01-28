using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    class SportCar : Car
    {
        public SportCar(string carName) : base(carName)
        {
            this.speed = 0;
        }

        public override void drive(Random rand)
        {    
            speed += rand.Next(1, 12);
        }
    }
}


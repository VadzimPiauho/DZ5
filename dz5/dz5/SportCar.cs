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
        }

        public override void drive()
        {
            throw new NotImplementedException();
        }
    }
}

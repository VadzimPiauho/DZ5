using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dz5
{
    
    class busCar : Car
    {
        public busCar(string carName) : base(carName)
        {
            this.speed = 0;
        }

        public override void drive()
        {
            throw new NotImplementedException();
        }

        
    }
}

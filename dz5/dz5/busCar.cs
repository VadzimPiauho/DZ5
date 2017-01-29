using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace dz5
{
    
    class busCar : Car
    {
        //private event Program.CarDelegate EventName;
        public busCar(string carName) : base(carName)
        {
            this.speed = 0;
        }

        public override void drive(Random rand)
        {
            //Thread.Sleep(1000);   
            speed += rand.Next(1, 5);
        }

        
    }
}

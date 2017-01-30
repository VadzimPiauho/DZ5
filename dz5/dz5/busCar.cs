using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace dz5
{
    public class busCar : Car
    {
        //public event MethodEvent onCount;
        public busCar(string carName) : base(carName)
        {
            this.distance = 0;
        }
        public override void drive(Random rand)
        {
            //Thread.Sleep(1000);   
            distance += rand.Next(1,10);

            if (distance >= 100)
            {
                distance = 100;
                onCountMetod();
            }
        }
        public override void Message()
        {
            Console.WriteLine("Автобус финишировал!");
        }
    }
}

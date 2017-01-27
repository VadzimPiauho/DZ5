using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    abstract class Car
    {
        public int speed;
        public string carName;

        public Car(string carName)
        {
            this.carName = carName;
            
        }

        public abstract void drive();

        public virtual void printSpeed()
        {
            Console.WriteLine($"Скорость {carName} составляет {speed}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    public abstract class Car
    {
        public delegate void MethodEvent();
        public event MethodEvent onCount;
        public int distance;
        public string carName;
        public Car(string carName)
        {
            this.carName = carName;
        }
        public abstract void drive(Random rand);
        public abstract void Message();
        public virtual void printSpeed()
        {
            Console.WriteLine($"{carName} прошел {distance}");
        }
        public virtual void onCountMetod()
        {
            if (onCount != null)
                onCount();
        }
    }
}

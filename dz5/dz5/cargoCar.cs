using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{

    class cargoCar: Car
    {
        public event EventHandler finish;
        public cargoCar(string carName) : base(carName)
        {
            this.speed = 0;
        }

        public override void drive(Random rand)
        {      
            speed += rand.Next(1, 10);
            if (speed >= 100)
            {
                if (finish != null) finish(this, EventArgs.Empty);
            }
        }
    }
}

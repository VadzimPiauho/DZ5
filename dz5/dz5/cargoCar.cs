using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{

    class cargoCar: Car
    {
        public cargoCar(string carName) : base(carName)
        {
        }

        public override void drive()
        {
            throw new NotImplementedException();
        }
    }
}

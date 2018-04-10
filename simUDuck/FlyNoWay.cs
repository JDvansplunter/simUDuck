using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class FlyNoWay : IflyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("There is no way i can fly");
        }
    }
}

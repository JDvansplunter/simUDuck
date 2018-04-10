using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class FlyBehaviour : IflyBehaviour
    {
        void IflyBehaviour.fly()
        {
            Console.WriteLine("i'm flying");
        }
    }
}

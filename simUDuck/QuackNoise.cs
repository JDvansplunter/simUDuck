using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class QuackNoise : IquackBehaviour
    {
        void IquackBehaviour.quack()
        {
            Console.WriteLine("Quack");
        }
    }
}

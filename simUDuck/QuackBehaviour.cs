using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class QuackBehaviour : IquackBehaviour
    {
        void IquackBehaviour.quack()
        {
            Console.WriteLine("Quack");
        }
    }
}

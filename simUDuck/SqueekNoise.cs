using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class SqueekNoise : IquackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeek!");
        }
    }
}

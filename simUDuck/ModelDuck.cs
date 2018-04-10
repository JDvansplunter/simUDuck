using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.flyBehaviour = new FlyNoWay();
            this.quackBehaviour = new NoNoise();
        }

        public void display()
        {
            Console.WriteLine("i'm a model duck");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehaviour = new QuackNoise();
            this.flyBehaviour = new FlyWithWings();
        }    
        
        public void display()
        {
            Console.WriteLine("ik ben een malle mallard");
        }
    }
}

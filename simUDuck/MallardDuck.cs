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
            this.quackBehaviour = new QuackBehaviour();
        }    
        
        public void display()
        {
            Console.WriteLine("ik ben een malle mallard");0
        }
    }
}

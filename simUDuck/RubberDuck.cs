using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.flyBehaviour = new FlyNoWay();
            this.quackBehaviour = new SqueekNoise();
        }
    }
}

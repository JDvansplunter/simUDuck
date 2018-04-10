using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class TurkeyAdapter : Duck
    {
        public Iturkey turkey;

        public TurkeyAdapter(Iturkey turkey)
        {
            this.turkey = turkey;
        }

        void Quack()
        {
            turkey.Gobble();
        }
        void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}

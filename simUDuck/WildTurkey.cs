using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class WildTurkey : Iturkey
    {
        public void Fly()
        {
            Console.WriteLine("i'm flying short distances");
        }

        public void Gobble()
        {
            Console.WriteLine("gobble gobble");
        }
    }
}

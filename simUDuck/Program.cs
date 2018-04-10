using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();

            MallardDuck mallardDuck = new MallardDuck();
            RubberDuck rubberDuck = new RubberDuck();

            mallardDuck.performFly();
            mallardDuck.performQuack();

            rubberDuck.performFly();
            rubberDuck.performQuack();

            ModelDuck modelDuck = new ModelDuck();
            modelDuck.performFly();
            modelDuck.setFlyBehaviour(new FlyWithRockets());
            modelDuck.performFly();

            Console.WriteLine(); Console.Read();
        }

        
    }
}

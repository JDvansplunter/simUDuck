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

            //mallardDuck.PerformFly();
            //mallardDuck.PerformQuack();

            //rubberDuck.PerformFly();
            //rubberDuck.PerformQuack();

            //ModelDuck modelDuck = new ModelDuck();
            //modelDuck.PerformFly();
            //modelDuck.SetFlyBehaviour(new FlyWithRockets());
            //modelDuck.PerformFly();
            WildTurkey wildTurkey = new WildTurkey();
            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("the turkey says");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("\n the duck says...");
            TestDuck(mallardDuck);

            Console.WriteLine("\n the tukeyAdapter says...");
            //TestDuck(turkeyAdapter);

            Console.WriteLine(); Console.Read();
        }

        static void TestDuck(Duck mallardDuck)
        {
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
        }
    }
}

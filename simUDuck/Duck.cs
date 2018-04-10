using System;

namespace simUDuck
{
    public class Duck
    {
        public IflyBehaviour flyBehaviour;
        public IquackBehaviour quackBehaviour;

        public void swim()
        {
            Console.WriteLine("all ducks float, even decoys");
        }
        public void performQuack()
        {
            quackBehaviour.quack();
        }

        public void performFly()
        {
            flyBehaviour.fly();
        }
        
        public void setFlyBehaviour(IflyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void setQuakBehaviour(IquackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
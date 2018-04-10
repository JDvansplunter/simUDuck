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
        public void PerformQuack()
        {
            quackBehaviour.quack();
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }
        
        public void SetFlyBehaviour(IflyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuakBehaviour(IquackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
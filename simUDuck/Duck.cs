using System;

namespace simUDuck
{
    public class Duck
    {
        public IflyBehaviour flybehaviour;
        public IquackBehaviour quackBehaviour;

        public void performQuack()
        {
            quackBehaviour.quack();
            flybehaviour.fly();
        }
    }
}
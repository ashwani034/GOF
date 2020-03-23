using System;
using System.Collections.Generic;
using System.Text;


namespace GOF.Strategy.DuckAppStrategy
{
    class claDuckAppClient
    {
        static void Main(string[] args)
        {
            Duck d = new MallardDuck();
            d.performQuack();
            d.performFly();
            d.display();

         

            Console.ReadLine();
        }
    }
    abstract class Duck
    {
        internal IFlyBehavior flyBehavior;
        internal IQuackBehavior quackBehavior;

        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void performFly()
        {
            flyBehavior.fly();
        }
        public virtual void swim()
        {
            Console.WriteLine("swiming...");
        }
        public abstract void display();
    }

    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Mallard duck display.....");
        }
    }
}

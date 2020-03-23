using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Strategy.DuckApp
{
    /// <summary>
    /// Simple duck app
    /// Problems: Code is duplicated in RubberDuck and DecoyDuck like fly method
    /// Changes in duck class affect other ducks
    /// </summary>
    class clsDuckApp
    {
        static void Main(string[] args)
        {
            Duck d = new MallardDuck();
            d.quack();
            d.display();

            Duck dd = new DecoyDuck();
            dd.quack();
            dd.fly();
            dd.display();

            Console.ReadLine();
        }
    }
    abstract class Duck
    {
        public virtual void quack()
        {
            Console.WriteLine("quacking...");
        }
        public virtual void swim()
        {
            Console.WriteLine("swiming...");
        }
        public virtual void fly()
        {
            Console.WriteLine("flying...");
        }
        public abstract void display();
    }
    class MallardDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("Mallard duck display.....");
        }
    }
    class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("Readhead duck display.....");
        }
    }
    /// <summary>
    /// Rubber duck not fly
    /// </summary>
    class RubberDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("squeaking.........");
        }
        public override void fly()
        {
            //Console.WriteLine("squeaking.........");
        }
        public override void display()
        {
            Console.WriteLine("Rubber duck display.....");
        }
    }
    /// <summary>
    /// Decoy duck not fly and quack
    /// </summary>
    class DecoyDuck : Duck
    {
        public override void quack()
        {
            //Console.WriteLine("squeaking.........");
        }
        public override void fly()
        {
            //Console.WriteLine("squeaking.........");
        }
        public override void display()
        {
            Console.WriteLine("Decoy duck display.....");
        }
    }
}

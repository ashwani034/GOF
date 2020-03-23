using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Strategy.DuckAppStrategy
{
    interface IQuackBehavior
    {
        void quack();
    }
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("duck quacking...");
        }
    }
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("duck squeaking...");
        }
    }
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
           
        }
    }
}

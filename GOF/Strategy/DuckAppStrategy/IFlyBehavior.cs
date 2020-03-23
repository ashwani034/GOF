using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Strategy.DuckAppStrategy
{
    interface IFlyBehavior
    {
        void fly();
    }
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("fly with wings...");
        }
    }
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            
        }
    }
}

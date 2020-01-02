using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.ObserverDesignPattern
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            try
            {
                if ((subject as Subject).State < 3)
                    Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}

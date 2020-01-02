using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.ObserverDesignPattern
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            try
            {
                if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
                    Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    
    }
}

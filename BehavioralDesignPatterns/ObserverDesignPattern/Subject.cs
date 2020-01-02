using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatternPrograms.BehavioralDesignPatterns.ObserverDesignPattern
{
    class Subject : ISubject
    {

        public int State { set; get; } = -0;

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            try
            {
                Console.WriteLine("Subject: Attached an Observer.");
                this.observers.Add(observer);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        public void Detach(IObserver observer)
        {
            try
            {
                this.observers.Remove(observer);
                Console.WriteLine("Subject: Detached an observer.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        public void Notify()
        {
            try
            {
                Console.WriteLine("Subject: Notifying observers...");

                foreach (var observer in observers)
                    observer.Update(this);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        public void SomeBusinessLogic()
        {
            try
            {
                Console.WriteLine("\nSubject: I'm doing something important.");
                this.State = new Random().Next(0, 10);

                Thread.Sleep(5000);

                Console.WriteLine("Subject: My state has just changed to: " + this.State);
                this.Notify();

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    
    }
}

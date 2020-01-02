/*
 *  Purpose: Program for Testing the Observer Design Pattern Program. 
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   02-01-2019
 */

using System;

namespace DesignPatternPrograms.BehavioralDesignPatterns.ObserverDesignPattern
{
    class ObserverMain
    {
        /// <summary>
        /// This Method is used to test the Observer Design Pattern.
        /// </summary>
        public static void Observer()
        {

            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Observer Design Pattern Program-----------------");
                Console.WriteLine();

                var subject = new Subject();
                var observerA = new ConcreteObserverA();
                subject.Attach(observerA);

                var observerB = new ConcreteObserverB();
                subject.Attach(observerB);

                subject.SomeBusinessLogic();
                subject.SomeBusinessLogic();

                subject.Detach(observerA);

                subject.SomeBusinessLogic();

            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }


        }
    }
}

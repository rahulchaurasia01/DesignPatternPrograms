using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatterns.SingletonPattern
{
    class Singleton
    {
        static int instanceCounter = 0;
        private static Singleton singleInstance = null;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        }

        public static Singleton SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    lock (lockObject)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new Singleton();
                        }
                    }
                }
                return singleInstance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }



    }
}

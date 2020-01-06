using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatterns.SingletonPattern
{
    class LazyInitialization
    {

        static int instanceCounter = 0;

        private static readonly Lazy<LazyInitialization> lazyInstance = new Lazy<LazyInitialization>(() => new LazyInitialization());

        private LazyInitialization()
        {
            instanceCounter++;
            Console.WriteLine("Instances Created: {0}", instanceCounter);
        }

        public static LazyInitialization LazyInstance
        {
            get
            {
                return lazyInstance.Value;
            }
        }
        

        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }

    }
}

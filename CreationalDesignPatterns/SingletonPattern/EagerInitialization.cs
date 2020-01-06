using System;

namespace DesignPatternPrograms.CreationalDesignPatterns.SingletonPattern
{
    class EagerInitialization
    {

        static int instanceCounter = 0;

        private EagerInitialization()
        {
            instanceCounter++;
            Console.WriteLine("Instances Created: {0}", instanceCounter);
        }

        public static EagerInitialization EagerInstance { get; } = new EagerInitialization();

        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrograms.CreationalDesignPatterns.SingletonPattern
{
    class SingletonPatterns
    {

        public static void SingletonPattern()
        {
            try
            {
                int choice;
                bool flag;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Eager Instialization");
                    Console.WriteLine("2. Lazy Instialization");
                    Console.WriteLine("3. Thread Safe Singleton");
                    Console.Write("Enter your Choice: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    Utility.ErrorMessage(flag);
                } while (!flag);
                switch(choice)
                {
                    case 1:
                        Console.WriteLine();
                        EagerInitialization fromEmployee = EagerInitialization.EagerInstance;
                        fromEmployee.LogMessage("Request Message from Employee");

                        EagerInitialization fromManager = EagerInitialization.EagerInstance;
                        fromManager.LogMessage("Request Message from Manager");
                        break;

                    case 2:
                        Console.WriteLine();
                        LazyInitialization fromEmployees = LazyInitialization.LazyInstance;
                        fromEmployees.LogMessage("Request Message from Employee");

                        LazyInitialization fromManagers = LazyInitialization.LazyInstance;
                        fromManagers.LogMessage("Request Message from Manager");
                        break;

                    case 3:
                        Parallel.Invoke(() => LogManagerRequest(), () => LogEmployeeRequest());
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. !!");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        public static void LogManagerRequest()
        {
            Singleton fromManager = Singleton.SingleInstance;
            fromManager.LogMessage("Request Message from Manager");
        }

        public static void LogEmployeeRequest()
        {
            Singleton fromEmployee = Singleton.SingleInstance;
            fromEmployee.LogMessage("Request Message from Employee");
        }

    }
}

/*
 *  Purpose: Entry Point For the Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   31-12-2019
 */

using System;
using DesignPatternPrograms.CreationalDesignPatterns.FactoryPattern;

namespace DesignPatternPrograms
{
    class Program
    {
        static void Main()
        {
            try
            {
                bool flag;
                int choice;

                do
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Welcome to BridgeLabz");
                        Console.WriteLine();
                        Console.WriteLine("1. Factory Pattern Program");
                        Console.WriteLine("2. Prototype Pattern Program");
                        Console.WriteLine("3. Observer Design Program");
                        Console.WriteLine("4. Visitor Design Program");
                        Console.WriteLine("10. Exit");
                        Console.Write("Enter Your Choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(flag);
                    } while (!flag);
                    flag = false;
                    switch (choice)
                    {
                        case 1:
                            CreationalDesignPatterns.FactoryPattern.Main.StartMain();
                            break;

                        case 2:
                            CreationalDesignPatterns.PrototypePattern.EmployeeMain.Employee();
                            break;

                        case 3:
                            BehavioralDesignPatterns.ObserverDesignPattern.ObserverMain.Observer();
                            break;

                        case 4:
                            BehavioralDesignPatterns.VisitorDesignPattern.VisitorMain.Visitor();
                            break;

                        case 10:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice !!!");
                            break;
                    }
                } while (!flag);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}

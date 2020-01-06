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
                        Console.WriteLine("1. Singleton Design Pattern Program");
                        Console.WriteLine("2. Factory Design Pattern Program");
                        Console.WriteLine("3. Prototype Design Pattern Program");
                        Console.WriteLine("4. Adapter Design Pattern Program");
                        Console.WriteLine("5. Facade Design Pattern Program");
                        Console.WriteLine("6. Proxy Desgin Pattern Program");
                        Console.WriteLine("7. Observer Design Program");
                        Console.WriteLine("8. Visitor Design Program");
                        Console.WriteLine("9. Mediator Design Program");
                        Console.WriteLine("10. Exit");
                        Console.Write("Enter Your Choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(flag);
                    } while (!flag);
                    flag = false;
                    switch (choice)
                    {

                        case 1:
                            CreationalDesignPatterns.SingletonPattern.SingletonPatterns.SingletonPattern();
                            break;

                        case 2:
                            CreationalDesignPatterns.FactoryPattern.Main.StartMain();
                            break;

                        case 3:
                            CreationalDesignPatterns.PrototypePattern.EmployeeMain.Employee();
                            break;

                        case 4:
                            StructuralDesignPatterns.AdapterDesignPattern.AdapterMain.Adapter();
                            break;

                        case 5:
                            StructuralDesignPatterns.FacadeDesignPattern.AddressBookProgram.AddressBook();
                            break;

                        case 6:
                            StructuralDesignPatterns.ProxyDesignPattern.ProxyMain.Proxy();
                            break;

                        case 7:
                            BehavioralDesignPatterns.ObserverDesignPattern.ObserverMain.Observer();
                            break;

                        case 8:
                            BehavioralDesignPatterns.VisitorDesignPattern.VisitorMain.Visitor();
                            break;

                        case 9:
                            BehavioralDesignPatterns.MediatorDesignPattern.MediatorMain.Mediator();
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

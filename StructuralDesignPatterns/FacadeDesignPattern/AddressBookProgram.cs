/*
 *  Purpose: Program to implement the Address Book Using Facade Design Pattern.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   04-01-2019
 */

using System;

namespace DesignPatternPrograms.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookProgram
    {
        
        /// <summary>
        /// This Method is used to test the AddressBookProgram Class.
        /// </summary>
        public static void AddressBook()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Address Book Program-----------------");
                Console.WriteLine();

                int choice;
                bool inputFlag, flag = false;

                
                AddressBookFeatures addressBookFeatures = new AddressBookFeatures();

                do
                {
                    do
                    {
                        Console.WriteLine("Welcome to Bridgelabz Address Book");
                        Console.WriteLine();
                        Console.WriteLine("1. Create Contact");
                        Console.WriteLine("2. Edit Contact");
                        Console.WriteLine("3. Delete Contact");
                        Console.WriteLine("4. Sort By Name");
                        Console.WriteLine("5. Sort By ZIP");
                        Console.WriteLine("6. Quit.");
                        Console.Write("Enter Your Choice: ");
                        inputFlag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(inputFlag);
                    } while (!inputFlag);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();;
                            addressBookFeatures.CreateAddressBook();
                            Console.WriteLine("New Contact has been Successfully Created. !!");
                            break;

                        case 2:
                            Console.WriteLine();
                            addressBookFeatures.EditAddressBook();
                            break;

                        case 3:
                            Console.WriteLine();
                            addressBookFeatures.DeleteAddressBook();
                            break;

                        case 4:
                            Console.WriteLine();
                            addressBookFeatures.SortByNameAddressBook();
                            break;

                        case 5:
                            Console.WriteLine();
                            addressBookFeatures.SortByZipAddressBook();
                            break;

                        case 6:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. !!");
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

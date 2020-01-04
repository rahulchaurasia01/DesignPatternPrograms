/*
 *  Purpose: The Utility Class is used to store the logic of the Object Oriented Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   04-01-2019
 * 
 */

using ConsoleTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatternPrograms.StructuralDesignPatterns.FacadeDesignPattern
{
    class Utility
    {
        public static string addressPath = @"C:\Users\User\source\repos\DesignPatternPrograms\DesignPatternPrograms\StructuralDesignPatterns\FacadeDesignPattern\AddressBook.json";

        /// <summary>
        /// It read the AddressBook  Data from json.
        /// </summary>
        /// <returns>It return the list of AddressBook Data</returns>
        public static List<CreateAddressBook> ReadAddressBookJson()
        {

            string addressString = File.ReadAllText(addressPath);

            var addressData = JsonConvert.DeserializeObject<AddressBookList>(addressString);

            List<CreateAddressBook> addressBookList;

            if (addressData == null)
                addressBookList = new List<CreateAddressBook>();
            else
                addressBookList = addressData.AddressBook;

            return addressBookList;
        }

        /// <summary>
        /// If the Conversion from string to int is not possible
        /// then it prints the error message.
        /// </summary>
        /// <param name="flag"></param>
        public static void ErrorMessage(bool flag)
        {
            try
            {
                if (!flag)
                    Console.WriteLine("Please Input the Number !!!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    
        /// <summary>
        /// It prints the error Message, If the Input value doesnt matches the regex.
        /// </summary>
        /// <param name="flag"></param>
        public static void AddressBookErrorMessage(bool flag, string str)
        {
            try
            {
                if (!flag)
                {
                    Console.WriteLine("Please Input the {0} Properly !!!", str);
                    Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Save the Data in jSon file.
        /// </summary>
        /// <param name="addressBooks"></param>
        /// <param name="addressPath"></param>
        public static void SaveAddressBookInJson(List<CreateAddressBook> addressBooks)
        {
            try
            {
                AddressBookList addressBookList1 = new AddressBookList
                {
                    AddressBook = addressBooks
                };

                string printAddressBook = JsonConvert.SerializeObject(addressBookList1);

                using StreamWriter streamWriter = new StreamWriter(addressPath);
                streamWriter.WriteLine(printAddressBook);

            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Display All the Address Book Data
        /// </summary>
        /// <param name="addressBooks"></param>
        public static void DisplayAddressBookData(List<CreateAddressBook> addressBooks)
        {
            try
            {
                if (addressBooks.Count == 0)
                    Console.WriteLine("Address Book is Empty");
                else
                {
                    int count = 1;

                    var table = new ConsoleTable("No.", "Name", "Mobile Number", "Email-Id", "Zip", "Address");
                    foreach (CreateAddressBook addressBook in addressBooks)
                    {
                        table.AddRow(count, addressBook.Name, addressBook.MobileNumber, addressBook.EmailId, addressBook.Zip, addressBook.Address);
                        count++;
                    }

                    table.Options.EnableCount = false;
                    table.Write();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
        
        /// <summary>
        /// Confirm with the user, whether they want to update their Address book or not.
        /// </summary>
        /// <returns></returns>
        public static bool ConfirmChange()
        {
            try
            {
                Console.Write("Are You Sure you want to update ur Address Data [y/n]: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return false;
            }
        }
    
    }
}

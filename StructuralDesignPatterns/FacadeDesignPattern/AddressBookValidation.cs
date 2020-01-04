using System;
using System.Text.RegularExpressions;

namespace DesignPatternPrograms.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookValidation
    {

        /// <summary>
        /// It return true If the validation Matches the pattern.
        /// </summary>
        /// <param name="name">Its a string</param>
        /// <returns></returns>
        public static string NameValidation()
        {
            try
            {
                string name;
                string pattern = @"^[a-zA-Z\s]*$";
                bool flag;

                do
                {
                    Console.Write("Enter Your Name: ");
                    name = Console.ReadLine();
                    flag = Regex.IsMatch(name, pattern);
                    Utility.AddressBookErrorMessage(flag, "Name");
                } while (!flag);

                return name;
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
            
        }

        /// <summary>
        /// It return true if the Address Validation matches the pattern.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string AddressValidation()
        {
            try
            {
                string address;
                string pattern = @"^[a-zA-Z0-9\,\-\.\s]*$";
                bool flag;

                do
                {
                    Console.Write("Enter Your Address: ");
                    address = Console.ReadLine();
                    flag = Regex.IsMatch(address, pattern);
                    Utility.AddressBookErrorMessage(flag, "Address");
                } while (!flag);

                return address;

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
            
        }

        /// <summary>
        /// It return true if the Email Validation Matches the Pattern.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string EmailValidation()
        {
            try
            {
                string email;
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                
                bool flag;

                do
                {
                    Console.Write("Enter Your Email-Id: ");
                    email = Console.ReadLine();
                    flag = Regex.IsMatch(email, pattern);
                    Utility.AddressBookErrorMessage(flag, "Email-Id");
                } while (!flag);

                return email;

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
            
        }

        /// <summary>
        /// It return true if the Mobile Number Validation Matches the Pattern.
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public static string MobileNumberValidation()
        {
            try
            {
                string mobileNumber;
                string pattern = @"^((\+)?(\d{2}[-])?(\d{10}){1})?(\d{11}){0,1}?$";
                bool flag;

                do
                {
                    Console.Write("Enter Your Mobile Number: ");
                    mobileNumber = Console.ReadLine();
                    flag = Regex.IsMatch(mobileNumber, pattern);
                    Utility.AddressBookErrorMessage(flag, "Mobile Number");
                } while (!flag);

                return mobileNumber;

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
            
        }

        /// <summary>
        /// It return true If the Zip Validation Matches the Pattern.
        /// </summary>
        /// <param name="zip"></param>
        /// <returns></returns>
        public static string ZipValidation()
        {
            try
            {
                string zip;
                string pattern = @"^[1-9][0-9]{5}$";
                bool flag;

                do
                {
                    Console.Write("Enter Your Zip: ");
                    zip = Console.ReadLine();
                    flag = Regex.IsMatch(zip, pattern);
                    Utility.AddressBookErrorMessage(flag, "Zip");
                } while (!flag);

                return zip;

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
            
        }


    }
}

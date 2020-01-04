using System;
using System.Collections.Generic;

namespace DesignPatternPrograms.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookFeatures 
    {

        private IAddressBook addressBook;

        public AddressBookFeatures()
        {
            addressBook = new CreateAddressBook();
        }

        /// <summary>
        /// It Create the New Address Book Data
        /// </summary>
        public void CreateAddressBook()
        {
            try
            {
                string name, mobileNumber, emailId, address, zip;

                name = AddressBookValidation.NameValidation();
                mobileNumber = AddressBookValidation.MobileNumberValidation();
                emailId = AddressBookValidation.EmailValidation();
                address = AddressBookValidation.AddressValidation();
                zip = AddressBookValidation.ZipValidation();

                CreateAddressBook createAddressBook = new CreateAddressBook
                {
                    Name = name,
                    MobileNumber = mobileNumber,
                    EmailId = emailId,
                    Address = address,
                    Zip = zip
                };

                List<CreateAddressBook> addressBooks = Utility.ReadAddressBookJson();
                addressBooks.Add(createAddressBook);
                Utility.SaveAddressBookInJson(addressBooks);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Edit the Specificed Data Address Book Data
        /// </summary>
        public void EditAddressBook()
        {
            try
            {
                List<CreateAddressBook> addressBooks = Utility.ReadAddressBookJson();

                if (addressBooks.Count == 0)
                {
                    Console.WriteLine("No Data Present in Address Book.");
                    return;
                }

                Utility.DisplayAddressBookData(addressBooks);

                int choice, count;
                bool inputFlag;
                string name = null, mobileNumber = null, email = null, address = null, zip = null;
                bool flag;
                do
                {
                    Console.WriteLine();
                    Console.Write("Please Choose which Contact you want to Edit: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= 0 || choice > addressBooks.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice");
                        Console.WriteLine();
                        Utility.DisplayAddressBookData(addressBooks);
                        flag = false;
                    }
                } while (!flag);

                count = 1;

                foreach (CreateAddressBook addressBook in addressBooks)
                {
                    if (count == choice)
                    {
                        name = addressBook.Name;
                        mobileNumber = addressBook.MobileNumber;
                        email = addressBook.EmailId;
                        address = addressBook.Address;
                        zip = addressBook.Zip;
                        break;
                    }
                    count++;
                }
                flag = false;
                count--;

                do
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Details for the Selected Address are: ");
                        Console.WriteLine("1. Name: {0}", name);
                        Console.WriteLine("2. Mobile Number: {0}", mobileNumber);
                        Console.WriteLine("3. Email: {0}", email);
                        Console.WriteLine("4. Address: {0}", address);
                        Console.WriteLine("5. Zip: {0}", zip);
                        Console.WriteLine("6. Exit");
                        Console.Write("Enter Your Choice: ");
                        inputFlag = int.TryParse(Console.ReadLine(), out choice);
                        Utility.ErrorMessage(inputFlag);
                    } while (!inputFlag);
                    Console.WriteLine();
                    string tempData;
                    switch (choice)
                    {
                        case 1:
                            do
                            {
                                tempData = AddressBookValidation.NameValidation();
                                Utility.AddressBookErrorMessage(inputFlag, "Name");
                            } while (!inputFlag);
                            if (Utility.ConfirmChange())
                            {
                                name = tempData;
                                addressBooks[count].Name = name;
                                Utility.SaveAddressBookInJson(addressBooks);
                                Console.WriteLine("Your Name Has Been Successfully Updated. !!");
                            }
                            else
                                addressBooks[count].Name = name;
                            break;

                        case 2:
                            do
                            {
                                tempData = AddressBookValidation.MobileNumberValidation();
                                Utility.AddressBookErrorMessage(inputFlag, "Mobile Number");
                            } while (!inputFlag);
                            if (Utility.ConfirmChange())
                            {
                                mobileNumber = tempData;
                                addressBooks[count].MobileNumber = mobileNumber;
                                Utility.SaveAddressBookInJson(addressBooks);
                                Console.WriteLine("Your Mobile Number Has Been Successfully Updated. !!");
                            }
                            else
                                addressBooks[count].MobileNumber = mobileNumber;

                            break;

                        case 3:
                            do
                            {
                                tempData = AddressBookValidation.EmailValidation();
                                Utility.AddressBookErrorMessage(inputFlag, "Email-Id");
                            } while (!inputFlag);
                            if (Utility.ConfirmChange())
                            {
                                email = tempData;
                                addressBooks[count].EmailId = email;
                                Utility.SaveAddressBookInJson(addressBooks);
                                Console.WriteLine("Your Email-Id Has Been Successfully Updated. !!");
                            }
                            else
                                addressBooks[count].EmailId = email;

                            break;

                        case 4:
                            do
                            {
                                tempData = AddressBookValidation.AddressValidation();
                                Utility.AddressBookErrorMessage(inputFlag, "Address");
                            } while (!inputFlag);
                            if (Utility.ConfirmChange())
                            {
                                address = tempData;
                                addressBooks[count].Address = address;
                                Utility.SaveAddressBookInJson(addressBooks);
                                Console.WriteLine("Your Address Has Been Successfully Updated. !!");
                            }
                            else
                                addressBooks[count].Address = address;
                            break;

                        case 5:
                            do
                            {
                                tempData = AddressBookValidation.ZipValidation();
                                Utility.AddressBookErrorMessage(inputFlag, "Zip");
                            } while (!inputFlag);
                            if (Utility.ConfirmChange())
                            {
                                zip = tempData;
                                addressBooks[count].Zip = zip;
                                Utility.SaveAddressBookInJson(addressBooks);
                                Console.WriteLine("Your Zip Has Been Successfully Updated. !!");
                            }
                            else
                                addressBooks[count].Zip = zip;
                            break;

                        case 6:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. !!!");
                            break;
                    }

                } while (!flag);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Delete the Data in Address Book
        /// </summary>
        public void DeleteAddressBook()
        {
            try
            {

                List<CreateAddressBook> addressBooks = Utility.ReadAddressBookJson();

                if (addressBooks.Count == 0)
                {
                    Console.WriteLine("No Address Data to Delete. !!!");
                    return;
                }

                Utility.DisplayAddressBookData(addressBooks);

                int choice;
                bool flag;
                do
                {
                    Console.WriteLine();
                    Console.Write("Please Choose which Contact you want to Delete: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= 0 || choice > addressBooks.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice");
                        Console.WriteLine();
                        Utility.DisplayAddressBookData(addressBooks);
                        flag = false;
                    }
                } while (!flag);

                Console.Write("Are You Sure, Do you want to Delete this Address Data: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    addressBooks.RemoveAt(choice - 1);
                    Console.WriteLine("This Address Data has been Successfully Deleted. !!");
                    Utility.SaveAddressBookInJson(addressBooks);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Sort the Address Book by name.
        /// </summary>
        public void SortByNameAddressBook()
        {
            try
            {
                List<CreateAddressBook> tempAddress = Utility.ReadAddressBookJson();
                tempAddress.Sort((addressName1, addressName2) => addressName1.Name.CompareTo(addressName2.Name));
                Utility.DisplayAddressBookData(tempAddress);
                Console.WriteLine();
                Console.Write("Do you want to Save the Data in Name Order [y/n]: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    Utility.SaveAddressBookInJson(tempAddress);
                    Console.WriteLine("The Data Has Been Saved in Name Order.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Sort the Address Book By Zip Order.
        /// </summary>
        public void SortByZipAddressBook()
        {
            try
            {
                List<CreateAddressBook> tempAddress = Utility.ReadAddressBookJson();
                tempAddress.Sort((addressName1, addressName2) => addressName1.Zip.CompareTo(addressName2.Zip));
                Utility.DisplayAddressBookData(tempAddress);
                Console.WriteLine();
                Console.Write("Do you want to Save the Data in Zip Order [y/n]: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    Utility.SaveAddressBookInJson(tempAddress);
                    Console.WriteLine("The Data Has Been Saved in Zip Order.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }

        }


    }
}

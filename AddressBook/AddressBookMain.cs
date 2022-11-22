using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> address = new List<Contact>();
        Dictionary<string, List<Contact>> addressBook = new Dictionary<string, List<Contact>>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Address Book");
            Console.WriteLine("Enter FirstName :");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName :");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State :");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP :");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber :");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            contact.Email = Console.ReadLine();
            address.Add(contact);
        }

        public void EditContact(string name)
        {
            foreach (var contact in address)
            {
                if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    Console.WriteLine("1. Address \n 2.City \n 3. State \n 4.Zip \n 5.Phone number");
                    int options = Convert.ToInt32(Console.ReadLine());
                    switch (options)
                    {
                        case 1: contact.Address = Console.ReadLine(); break;
                        case 2: contact.City = Console.ReadLine(); break;
                        case 3: contact.State = Console.ReadLine(); break;
                        case 4: contact.Zip = Convert.ToInt32(Console.ReadLine()); break;
                        case 5: contact.PhoneNumber = Console.ReadLine(); break;
                    }
                }
            }
        }

        public void DeleteContact(string name)
        {
            Contact deleteContact = new Contact();
            foreach (var contact in address)
            {
                if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    deleteContact = contact;
                }
                address.Remove(deleteContact);
            }
        }

        public void Display()
        {
            foreach (var contact in address)
            {

                Console.WriteLine("Contact Details" + "\n" +
               contact.FirstName + "\n" +
               contact.LastName + "\n" +
               contact.Address + "\n" +
               contact.City + "\n" +
               contact.State + "\n" +
               contact.Zip + "\n" +
               contact.PhoneNumber + "\n" +
               contact.Email);
            }
        }

        public void CreateDictionaryContact()
        {
            Console.WriteLine("Enter name to add Addressbook");
            string name = Console.ReadLine();
            addressBook.Add(name, address);
            address = new List<Contact>();
        }

        public void DisplayDictionary()
        {
            foreach (var data in addressBook)
            {
                Console.WriteLine(data.Key);
                foreach (var contact in data.Value)
                {
                    Console.WriteLine(contact.FirstName + "\n" +
                                      contact.LastName + "\n" +
                                      contact.Address + "\n" +
                                      contact.City + "\n" +
                                      contact.State + "\n" +
                                      contact.Zip + "\n" +
                                      contact.PhoneNumber + "\n" +
                                      contact.Email);
                }
            }
        }
    }
}
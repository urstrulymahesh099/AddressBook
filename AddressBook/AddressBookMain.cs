using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookMain
    {
        Contact contact = new Contact();
        List<Contact>address = new List<Contact> ();
        public void Display()
        { 
            Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" +
                "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);
        }
        public void CreateContact()
        {


            Console.Write("Enter  FirstName: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter  LastName: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter  Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter  City: ");
            contact.City = Console.ReadLine();
            Console.Write("Enter  State: ");
            contact.State = Console.ReadLine();
            Console.Write("Enter  Zip: ");
            contact.Zip = Int32.Parse(Console.ReadLine());
            Console.Write("Enter  PhoneNumber: ");
            contact.PhoneNumber = (Console.ReadLine());
            Console.Write("Enter  Email: ");
            contact.Email = Console.ReadLine();
            address.Add(contact);
        }
        public void Edit()
        {
            CreateContact();
            Console.WriteLine("Enter the name you want to Edit Contact");
            string name = Console.ReadLine();
            foreach (var contact in address)
            {

                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("Enter the name you want to Edit Contact");
                    Console.WriteLine("1. Address\n 2. City\n 3. State\n 4. Zip\n 5. Phone Number\n 6. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter updated Address");
                            contact.Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter updated City");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter updated State");
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter updated Zip");
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter updated Phone Number");
                            contact.PhoneNumber =(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter updated Email");
                            contact.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }

    }
}

using AddressBook;
using System;
using System.Net;

namespace AddresBook 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            {
                contact.FirstName = Console.ReadLine();
                contact.LastName = Console.ReadLine();
                contact.Address = Console.ReadLine();
                contact.City = Console.ReadLine();
                contact.State = Console.ReadLine();
                contact.Zip = Convert.ToInt64(Console.ReadLine());
                contact.PhoneNumber = Console.ReadLine();
                contact.Email = Console.ReadLine();
            };
            Console.WriteLine("Contact details" + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}
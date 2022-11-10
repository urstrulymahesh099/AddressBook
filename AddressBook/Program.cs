using AddressBook;
using System;
using System.Net;

namespace AddresBook 
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Welcome to Address Book Problem Statement\n");               
                Console.WriteLine("1. Create a new Contact \n2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter your details : \n");
                        Console.WriteLine("First Name - " + "\n" + "Last Name - " + "\n" + "Address - " + "\n" +
                                        "City Name - " + "\n" + "State Name - " + "\n" + "Zip Code - " + "\n" +
                                        "Phone Number - " + "\n" + "Email ID - ");
                        NewContact create = new NewContact();
                        create.Create();
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        condition = false;
                        break;
                }
            }
        }
    }
}
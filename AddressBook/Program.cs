using AddressBook;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Net;

namespace AddresBook 
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            bool choice = true;
            while(choice)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Create a Contact\n2. Edit a Contact\n3.Delete a Contact\n. Exit");
                AddressBookMain add = new AddressBookMain();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.CreateContact();
                        add.Display();
                        break;
                    case 2:
                        add.Edit();
                        add.Display();
                        break;
                    case 3:
                        add.Delete();
                        break;
                    default:
                        choice = false;
                        break;
                }
            }


        }
    }
}
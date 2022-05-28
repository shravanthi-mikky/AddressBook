using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FileIOOperations
    {
        public List<Contact> People1 = new List<Contact>();
        public void WriteToTextFile()
        {
            string ABC = @"C:\Users\santo\OneDrive\Desktop\CSharpCodes\AddressBook\AddressBook\TextFile1.txt";
            using (TextWriter sw = File.CreateText(ABC))
            {
                foreach (Contact item in People1)
                {
                    sw.WriteLine("First Name:" + item.firstName.ToString());
                }
            }
        }
        public void AddPerson1()
        {
            Contact contact = new Contact();
            int Flag = 0;
            Console.WriteLine("Enter the First name :");
            contact.firstName = Console.ReadLine();
            string FirstNameToBeAdded = contact.firstName;
            foreach (var data in People1)
            {
                if (People1.Exists(data => data.firstName == FirstNameToBeAdded))
                {
                    Flag++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record.");
                    break;
                }
            }
            if (Flag == 0)
            {
                Console.WriteLine("Enter the Last name :");
                contact.lastName = Console.ReadLine();
                Console.WriteLine("Enter the Address :");
                contact.address = Console.ReadLine();
                Console.WriteLine("Enter the City :");
                contact.city = Console.ReadLine();
                Console.WriteLine("Enter the State :");
                contact.state = Console.ReadLine();
                Console.WriteLine("Enter the Zip Code :");
                contact.zip = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the Email :");
                contact.email = Console.ReadLine();
                Console.WriteLine("Enter the Phone Number :");
                contact.phoneNumber = Console.ReadLine();
            }
            People1.Add(contact);
        }

    }

}

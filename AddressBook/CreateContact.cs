using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateContact
    {

        public List<Contact> People = new List<Contact>();
        public void AddPerson()
        {
            //People.Add(this);
            Contact contact = new Contact();
            Console.WriteLine("Enter the First name :");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last name :");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the Address :");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter the City :");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter the State :");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter the Zip Code :");
            contact.zip = Console.ReadLine();
            Console.WriteLine("Enter the Email :");
            contact.email = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number :");
            contact.phoneNumber = Console.ReadLine();
            People.Add(contact);
            //Display();
        }
       
        public void Display()
        {
            foreach(Contact contact in People)
            {
                Console.WriteLine("Name of person : " + contact.firstName + " " + contact.lastName);
                Console.WriteLine("Address of person is : "+contact.address);
                Console.WriteLine("City : "+contact.city);
                Console.WriteLine("State :"+contact.state);
                Console.WriteLine("Zip :"+contact.zip);
                Console.WriteLine("Email of person : " + contact.email);
                Console.WriteLine("Phone Number of person : " + contact.phoneNumber);
            }
        }
    }
}

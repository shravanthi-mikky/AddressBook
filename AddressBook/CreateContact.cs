﻿using System;
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
        }

        public void Display()
        {
            foreach (var data in People)
            {
                if (People.Contains(data))
                    Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                Console.WriteLine("Address of person is : " + data.address);
                Console.WriteLine("City : " + data.city);
                Console.WriteLine("State :" + data.state);
                Console.WriteLine("Zip :" + data.zip);
                Console.WriteLine("Email of person : " + data.email);
                Console.WriteLine("Phone Number of person : " + data.phoneNumber);
            }
        }
        public void edit()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.firstName == null)
                {
                    Console.WriteLine("Contact for {0} count not be found.", name);
                }
                else if (data.firstName == name)
                {
                    Console.WriteLine("choose the option to change the data : \n1) firstName\n2)lastName\n3)address\n4)City\n5)State\n6)Zip\n7)Email\n8)Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first name : ");
                            string frstName = Console.ReadLine();
                            data.firstName = frstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the last name : ");
                            string lstName = Console.ReadLine();
                            data.lastName = lstName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string addrss = Console.ReadLine();
                            data.address = addrss;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the city : ");
                            string cty = Console.ReadLine();
                            data.city = cty;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the state : ");
                            string State = Console.ReadLine();
                            data.state = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the zip Code : ");
                            string Zip = Console.ReadLine();
                            data.zip = Zip;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the email : ");
                            string Email = Console.ReadLine();
                            data.email = Email;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Console.ReadLine();
                            data.phoneNumber = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("please choose from above options :");
                            break;
                    }

                }

            }

        }
    }
}
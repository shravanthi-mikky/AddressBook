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
        public Dictionary<string, List<Contact>> Dictionary1 = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> Dictionary2 = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> Dictionary3 = new Dictionary<string, List<Contact>>();

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
            contact.zip = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Email :");
            contact.email = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number :");
            contact.phoneNumber = Convert.ToInt16(Console.ReadLine());
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
                if (data.firstName != name)
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
                            int Zip = Convert.ToInt16(Console.ReadLine());
                            data.zip = Zip;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the email : ");
                            string Email = Console.ReadLine();
                            data.email = Email;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the Phone Number : ");
                            int PhoneNumber = Convert.ToInt16(Console.ReadLine());
                            data.phoneNumber = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("please choose from above options :");
                            break;
                    }

                }

            }

        }
        public void RemoveContact()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            try
            {
                foreach (var data in People)
                {
                    if (People.Contains(data))
                    {
                        if (data.firstName == name)
                        {
                            Console.WriteLine("given name contact exists");
                            People.Remove(data);

                            Console.WriteLine("contact deleted successfully");
                            return;
                        }
                    }
                }
                Console.WriteLine("given name contact does not exists");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddMultipleContacts(int n)
        {
            while(n > 0)
            {
                AddPerson();
                n--;
            }
        }
        public void AddUniqueContacts()
        {
            Console.WriteLine("Choose the dictionary to store values in it :\n1)Dictionary1\n2)Dictionary2\n3)Dictionary3");
            int dict = Convert.ToInt16(Console.ReadLine());
            switch(dict)
            {
                //Logic to Add to Dictionary1
                case 1:
                    Console.WriteLine("Welcome to Dictionary1");
                    Console.WriteLine("Enter the First name : ");
                    string name = Console.ReadLine().ToLower();
                    foreach (var data in People)
                    {
                        if (People.Contains(data))
                        {
                            if (data.firstName == name)
                            {
                                Console.WriteLine("Enter the Unique name : ");
                                string unique = Console.ReadLine().ToLower();
                                if (Dictionary1.ContainsKey(unique))
                                {
                                    Console.WriteLine("Person name already exists! ");
                                }
                                Dictionary1.Add(unique, People);
                                Console.WriteLine("added in dictionary!");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Contact list doesn't exist! Please create a contact list!");
                    //return;
                    break;
                //Logic to Add to Dictionary2
                case 2:
                    Console.WriteLine("Welcome to Dictionary2");
                    Console.WriteLine("Enter the First name : ");
                    string name1 = Console.ReadLine().ToLower();
                    foreach (var data in People)
                    {
                        if (People.Contains(data))
                        {
                            if (data.firstName == name1)
                            {
                                Console.WriteLine("Enter the Unique name : ");
                                string unique = Console.ReadLine().ToLower();
                                if (Dictionary2.ContainsKey(unique))
                                {
                                    Console.WriteLine("Person name already exists! ");
                                }
                                Dictionary2.Add(unique, People);
                                Console.WriteLine("added in Dictionary2!");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Contact list doesn't exist! Please create a contact list!");
                   // return;
                    break;
                // Logic to Add to Dictionary3
                case 3:
                    Console.WriteLine("Welcome to Dictionary3");
                    Console.WriteLine("Enter the First name : ");
                    string name3 = Console.ReadLine().ToLower();
                    foreach (var data in People)
                    {
                        if (People.Contains(data))
                        {
                            if (data.firstName == name3)
                            {
                                Console.WriteLine("Enter the Unique name : ");
                                string unique = Console.ReadLine().ToLower();
                                if (Dictionary3.ContainsKey(unique))
                                {
                                    Console.WriteLine("Person name already exists! ");
                                }
                                Dictionary3.Add(unique, People);
                                Console.WriteLine("added in dictionary!");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Contact list doesn't exist! Please create a contact list!");
                   // return;
                    break;
                default:
                    Console.WriteLine("please choose correct option!");
                    break;
            }
            
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Choose the dictionary you want to print : \n1)Dictionary1\n2)Dictionary2\n3)Dictionary3");
            int dict = Convert.ToInt32(Console.ReadLine());
            switch(dict)
            {
                // Logic to Display for Dictionary1
                case 1:
                    Console.WriteLine("Enter the unique name (key value) : ");
                    string name = Console.ReadLine();
                    foreach (var contact in Dictionary1)
                    {
                        if (contact.Key.Contains(name))
                        {
                            foreach (var data in contact.Value)
                            {
                                Console.WriteLine("The contact of " + data.firstName + " Details are");
                                Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                                Console.WriteLine("Address of person is : " + data.address);
                                Console.WriteLine("City : " + data.city);
                                Console.WriteLine("State :" + data.state);
                                Console.WriteLine("Zip :" + data.zip);
                                Console.WriteLine("Email of person : " + data.email);
                                Console.WriteLine("Phone Number of person : " + data.phoneNumber);

                            }
                        }

                        return;
                    }
                    break;
                // Logic to Display for Dictionary2
                case 2:
                    Console.WriteLine("Enter the unique name (key value) : ");
                    string name2 = Console.ReadLine();
                    foreach (var contact in Dictionary2)
                    {
                        if (contact.Key.Contains(name2))
                        {
                            foreach (var data in contact.Value)
                            {
                                Console.WriteLine("The contact of " + data.firstName + " Details are");
                                Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                                Console.WriteLine("Address of person is : " + data.address);
                                Console.WriteLine("City : " + data.city);
                                Console.WriteLine("State :" + data.state);
                                Console.WriteLine("Zip :" + data.zip);
                                Console.WriteLine("Email of person : " + data.email);
                                Console.WriteLine("Phone Number of person : " + data.phoneNumber);

                            }
                        }

                        return;
                    }
                    break;
                // Logic to Display for Dictionary3
                case 3:
                    Console.WriteLine("Enter the unique name (key value) : ");
                    string name3 = Console.ReadLine();
                    foreach (var contact in Dictionary3)
                    {
                        if (contact.Key.Contains(name3))
                        {
                            foreach (var data in contact.Value)
                            {
                                Console.WriteLine("The contact of " + data.firstName + " Details are");
                                Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                                Console.WriteLine("Address of person is : " + data.address);
                                Console.WriteLine("City : " + data.city);
                                Console.WriteLine("State :" + data.state);
                                Console.WriteLine("Zip :" + data.zip);
                                Console.WriteLine("Email of person : " + data.email);
                                Console.WriteLine("Phone Number of person : " + data.phoneNumber);

                            }
                        }

                        return;
                    }
                    break;
                default :
                    break;
            }
            Console.WriteLine("Oops! Unique Contact does not exist.Please create a unique contact.");
            return;
        }
    }
}
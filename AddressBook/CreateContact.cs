﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using CsvHelper;
using Newtonsoft.Json;

namespace AddressBook
{
    public class CreateContact
    {
        string csvPath = @"C:\Users\Admin\Desktop\CSharp\AddressBook\AddressBook\Class1.csv";
        string json = @"C:\Users\Admin\Desktop\CSharp\AddressBook\AddressBook\jsonFile.json";
        string path = @"C:\Users\Admin\Desktop\CSharp\AddressBook\AddressBook\TextFile1.txt";

        public List<Contact> People = new List<Contact>();
        public Dictionary<string, List<Contact>> Dictionary1 = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> DictionaryCity = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> DictionaryState = new Dictionary<string, List<Contact>>();
        public void AddPerson()
        {

            Contact contact = new Contact();
            int Flag = 0;
            Console.WriteLine("Enter the First name :");
            contact.firstName = Console.ReadLine();
            string FirstNameToBeAdded = contact.firstName;
            foreach (var data in People)
            {
                if (People.Exists(data => data.firstName == FirstNameToBeAdded))
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
            People.Add(contact);
        }
        // sorting the contacts list in alphabetical order of firstName
        public void SortingList()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = People.OrderBy(s => s.firstName).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                    Console.WriteLine("Address of person is : " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State :" + data.state);
                    Console.WriteLine("Zip :" + data.zip);
                    Console.WriteLine("Email of person : " + data.email);
                    Console.WriteLine("Phone Number of person : " + data.phoneNumber);
                }                    
            }
        }
        // sorting the contact list by city name in alphabetical order
        public void SortingList_city()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = People.OrderBy(s => s.city).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                    Console.WriteLine("Address of person is : " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State :" + data.state);
                    Console.WriteLine("Zip :" + data.zip);
                    Console.WriteLine("Email of person : " + data.email);
                    Console.WriteLine("Phone Number of person : " + data.phoneNumber);
                }
            }
        }
        // sorting the contact list by state name in alphabetical order
        public void SortingList_State()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = People.OrderBy(s => s.state).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                    Console.WriteLine("Address of person is : " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State :" + data.state);
                    Console.WriteLine("Zip :" + data.zip);
                    Console.WriteLine("Email of person : " + data.email);
                    Console.WriteLine("Phone Number of person : " + data.phoneNumber);
                }
            }
        }
        // sorting the contact list by zip
        public void SortingList_Zip()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = People.OrderBy(s => s.zip).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                    Console.WriteLine("Address of person is : " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State :" + data.state);
                    Console.WriteLine("Zip :" + data.zip);
                    Console.WriteLine("Email of person : " + data.email);
                    Console.WriteLine("Phone Number of person : " + data.phoneNumber);
                }
            }
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
        //uc8
        public void SearchByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string WantedCityOrState = Console.ReadLine();
            foreach (var data in People)
            {
                string ActualCity = data.city;
                string ActualState = data.state;
               // DictionaryCity[ActualCity].Add(data);
                if (People.Exists(data => (ActualCity == WantedCityOrState) || (ActualState == WantedCityOrState)))
                {
                    Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                    Console.WriteLine("Address of person is : " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State :" + data.state);
                    Console.WriteLine("Zip :" + data.zip);
                    Console.WriteLine("Email of person : " + data.email);
                    Console.WriteLine("Phone Number of person : " + data.phoneNumber);
                }
            }
        }
        public void CountByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string WantedCityOrState = Console.ReadLine();
            int Count = 0;
            foreach (var data in People)
            {
                string ActualCity = data.city;
                string ActualState = data.state;
                if (People.Exists(data => (ActualCity == WantedCityOrState) || (ActualState == WantedCityOrState)))
                {
                    Count++;
                }
            }
            Console.WriteLine("There are {0} Persons in {1}", Count, WantedCityOrState);
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
            while (n > 0)
            {
                AddPerson();
                n--;
            }
        }
        public void AddUniqueContacts()
        {
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
            return;
        }        
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter the unique name (key value) : ");
            string name = Console.ReadLine();
            foreach (var contacts in Dictionary1)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The contact of " + data.firstName + " Details are");
                        Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                        Console.WriteLine("Address of person is : " + data.address);
                        Console.WriteLine("City : " + data.city);
                        Console.WriteLine("State :" + data.state);
                        Console.WriteLine("Zip :" + data.zip);
                        Console.WriteLine("Email of person : " + data.email);
                        Console.WriteLine("Phone Number of person : " + data.phoneNumber);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("This unique name doesnt exists!");
                }
            }
            Console.WriteLine("Oops! Unique Contact does not exist.Please create a unique contact.");
        }
        // uc9 Dictionary for the City and state
        public void ContactByCityInDictionary()
        {
            try
            {
                var data = People.GroupBy(x => x.city);
                foreach (var cities in data)
                {
                    List<Contact> cityList = new List<Contact>();
                    foreach (var city in cities)
                    {
                        cityList.Add(city);
                    }
                    DictionaryCity.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
        //Display of city dictionary      
        public void DictionayCity_Display()
        {
            if (DictionaryCity.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (DictionaryCity.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contact>> addressBooks in DictionaryCity)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (Contact items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.firstName + " " + items.lastName}, Phone Number: {items.phoneNumber}, City: {items.city}, State: {items.state}" +
                            $"\n Address: {items.address}, Zipcode: {items.zip}, Email: {items.email}");
                        Console.WriteLine();
                    }
                }
            }
        }
        public void ContactByStateInDictionary()
        {
            // adding list to states dictionary
            try
            {
                var data = People.GroupBy(x => x.state);
                foreach (var states in data)
                {
                    List<Contact> stateList = new List<Contact>();
                    foreach (var state in states)
                    {
                        stateList.Add(state);
                    }
                    DictionaryState.Add(states.Key, stateList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of state dictionary      
        public void DictionayState_Display()
        {
            if (DictionaryState.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (DictionaryState.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contact>> addressBooks in DictionaryState)
                {
                    Console.WriteLine("Contacts From State: " + addressBooks.Key);
                    foreach (Contact items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.firstName + " " + items.lastName}, Phone Number: {items.phoneNumber}, City: {items.city}, State: {items.state}" +
                            $"\n Address: {items.address}, Zipcode: {items.zip}, Email: {items.email}");
                        Console.WriteLine();
                    }
                }
            }
        }
        //write to the text file
        public void WriteToTextFile()
        {
            using (TextWriter sw = File.AppendText(path))
            {
                foreach (Contact item in People)
                {   
                    sw.WriteLine("FirstName :" + item.firstName.ToString());
                    sw.WriteLine("lastName :" + item.lastName.ToString());
                    sw.WriteLine("Email ID :" + item.email.ToString());
                    sw.WriteLine("Mobile Number :" + item.phoneNumber.ToString());
                    sw.WriteLine("City  :" + item.city.ToString());
                    sw.WriteLine("State :" + item.state.ToString());
                    sw.WriteLine("ZIP :" + item.zip.ToString());
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Text file written to IO file");
        }
        //read from text file
        public void ReadFileIO()
        {
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Reading All the Text from Text file (TextFile1.txt)");
            Console.WriteLine(lines);
        }
        //write to json (Serialize json file)

        public void WriteJson()
        {
            foreach(Contact item in People)
            {
                string json1 = JsonConvert.SerializeObject(People);
                File.WriteAllText(json, json1);

            }
            Console.WriteLine("Copied all data");

        }
        //read from json (Deserialize fron json file)
        public void ReadJsonFile()
        {
            string jsonData = File.ReadAllText(json);
            var jsonResult = JsonConvert.DeserializeObject<List<Contact>>(jsonData).ToList();
            Console.WriteLine("Reading from Json file");
            foreach (var data in jsonResult)
            {
                Console.WriteLine("Name of person : " + data.firstName + " " + data.lastName);
                Console.WriteLine("Address of person is : " + data.address);
                Console.WriteLine("City : " + data.city);
                Console.WriteLine("State :" + data.state);
                Console.WriteLine("Zip :" + data.zip);
                Console.WriteLine("Email of person : " + data.email);
                Console.WriteLine("Phone Number of person : " + data.phoneNumber);
            }
        }
        //write to csv file
        public void WriteCsvFile()
        {
            StreamWriter sw = new StreamWriter(csvPath);
            CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture);

            foreach (var book in Dictionary1.Values)
            {
                cw.WriteRecords<Contact>(book);
            }
            Console.WriteLine("Dictionary1 is added to CSV file Successfully!");
            sw.Flush();
            sw.Close();
        }
        //read from csv file
        public void ReadCsvFile()
        {
            StreamReader sr = new StreamReader(csvPath);
            CsvReader cr = new CsvReader(sr, CultureInfo.InvariantCulture);
            List<Contact> readResult = cr.GetRecords<Contact>().ToList();
            Console.WriteLine("Reading from CSV file");
            foreach (var item in readResult)
            {
                Console.WriteLine(item.ToString());
            }
            sr.Close();
        }

    }
}

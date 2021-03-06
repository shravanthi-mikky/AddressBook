// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Address Book!");
CreateContact contact1 = new CreateContact();
AddressBookRepo repo = new AddressBookRepo();   
while (true)
{
    Console.WriteLine("Enter the option : \n1)Add Contact\n2)Display contact\n3 Edit Contact\n4)Remove Contact\n5)Add Multiple Contacts " +
        "\n6)AddUniqueContacts\n7)Display Unique contacts\n8)Search name by City or State\n9)Get Count of Persons by City or State" +
        "\n10)Maintain Dictionary_city\n11)Maintain Dictionary_state\n12)Sorting list by firstNames\n13)Sorting list by city\n14)Sorting list by state" +
        "\n15)Sorting list by zip\n16) Write to File IO\n17)read to file IO\n18)Write to json(serialize)\n19)Read from json(Deserialize)" +
        "\n20)WriteCsvFile\n21)ReadCsvFile\n22)Display of AddressBook\n23)Display of PersonDetail1\n24)Display of Address_Book1\n25)Display of PersonTypes1" +
        "\n26)Display of PersonsDetail_Type1\n27)Display of Employee_Department1\n28)Update Employee Details\n29)Add Column DateAdded" +
        "\n30)Contacts in date range\n31)count by city / State");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            contact1.AddPerson();
            break;
        case 2:
            contact1.Display();
            break;
        case 3:
            contact1.edit();
            break;
        case 4:
            contact1.RemoveContact();
            break;
        case 5:
            Console.WriteLine("Please enter number of contacts you want to add : ");
            int n=Convert.ToInt32(Console.ReadLine());
            contact1.AddMultipleContacts(n);
            break;
        case 6:
            contact1.AddUniqueContacts();
            break;
        case 7:
            contact1.DisplayUniqueContacts();
            break;
        case 8:
            contact1.SearchByCityState();
            break;
        case 9:
            contact1.CountByCityState();
            break;
        case 10:
            contact1.ContactByCityInDictionary();
            contact1.DictionayCity_Display();
            break;
        case 11:
            contact1.ContactByStateInDictionary();
            contact1.DictionayState_Display();
            break;
        case 12:
            contact1.SortingList();
            break;
        case 13:
            contact1.SortingList_city();
            break;
        case 14:
            contact1.SortingList_State();
            break;
        case 15:
            contact1.SortingList_Zip();
            break;
        case 16:
            contact1.WriteToTextFile();
            break;
        case 17:
            contact1.ReadFileIO();
            break;
        case 18:
            contact1.WriteJson();
            break;
        case 19:
            contact1.ReadJsonFile();
            break;
        case 20:
            contact1.WriteCsvFile();
            break;
        case 21:
            contact1.ReadCsvFile();
            break;
        case 22:
            Console.WriteLine("Display of AddressBook");
            repo.GetAllContactOf_AddressBook();
            Console.WriteLine("*********************************************************");
            break;
        case 23:
            Console.WriteLine("Display of PersonDetail1");
            repo.GetAllContactOf_PersonDetail1();
            Console.WriteLine("*********************************************************");
            break;
        case 24:
            Console.WriteLine("Display of Address_Book1");
            repo.GetAllContactOf_Address_Book1();
            Console.WriteLine("*********************************************************");
            break;
        case 25:
            Console.WriteLine("Display of PersonTypes1");
            repo.GetAllContactOf_PersonTypes1();
            Console.WriteLine("*********************************************************");
            break;
        case 26:
            Console.WriteLine("Display of PersonsDetail_Type1");
            repo.GetAllContactOf_PersonsDetail_Type1();
            Console.WriteLine("*********************************************************");
            break;
        case 27:
            Console.WriteLine("Display of Employee_Department1");
            repo.GetAllContactOf_Employee_Department1();
            Console.WriteLine("*********************************************************");
            break;
        case 28:
            Console.WriteLine("Display of PersonDetail1");
            string address = repo.updateEmployeeDetails();
            Console.WriteLine(address);
            Console.WriteLine("*********************************************************");
            break;
        case 29:
            repo.AddColumn_DateAdded_EmployeeDetails();
            break;
        case 30:
            repo.GetDetailsInPeroid();
            break;
        case 31:
            int countCity = repo.CountOfEmployeeDetailsByCity();
            Console.WriteLine("Count of Records by City :"+countCity);
            int countstate = repo.CountOfEmployeeDetailsByState();
            Console.WriteLine("Count of Records by state :" + countstate);
            break;
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }

}


// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Address Book!");
CreateContact contact1 = new CreateContact();
while (true)
{
    Console.WriteLine("Enter the option : \n1)Add Contact\n2)Display contact\n3 Edit Contact\n4)Remove Contact\n5)Add Multiple Contacts \n6)AddUniqueContacts\n7)Display Unique contacts\n8)Search name by City or State\n9)Get Count of Persons by City or State\n10)Maintain Dictionary_city\n11)Maintain Dictionary_state\n12)Sorting list by firstNames\n13)Sorting list by city\n14)Sorting list by state\n15)Sorting list by zip\n16) Write to File IO\n17)read to file IO\n18)Write to json(serialize)\n19)Read from json(Deserialize)\n20)Write to CSV file\n21)Read from CSV file ");
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
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }

}


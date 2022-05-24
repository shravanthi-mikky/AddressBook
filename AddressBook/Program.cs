// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Address Book!");
CreateContact contact1 = new CreateContact();
while (true)
{
    Console.WriteLine("Enter the option : \n1)Add Contact\n2)Display contact\n3 Edit Contact\n4)Remove Contact\n5)Add Multiple Contacts \n6)AddUniqueContacts\n7)Display Unique contacts\n8) Search name by City or State ");
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
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }

}


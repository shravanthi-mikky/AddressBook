// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Address Book!");
CreateContact contact1 = new CreateContact();
while (true)
{
    Console.WriteLine("Enter the option : \n1)Add Contact\n2)Display contact\n3 Edit Contact");
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
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }

}


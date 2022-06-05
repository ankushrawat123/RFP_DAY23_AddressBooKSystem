// See https://aka.ms/new-console-template for more information
using RFP_DAY_23_ADDRESSBOOK_Lambda_;


Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM ");

Console.WriteLine("ENTER \n1 FOR CREATE CONTACTS PROGRAM \n2 FOR ADDING NEW CONTACTS PROGRAM");
int number = Int32.Parse(Console.ReadLine());
switch(number)
{
    case 1:
        CreateContacts obj1 = new CreateContacts();
        obj1.CreateContactMethod();
        obj1.print();
        break;

    case 2:
        NewContacts obj2 = new NewContacts();
        obj2.newContacts();
        obj2.printcont();
        break;
}

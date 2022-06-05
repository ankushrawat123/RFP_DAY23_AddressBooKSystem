using RFP_DAY_23_ADDRESSBOOK_Lambda_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY_23_ADDRESSBOOK_Lambda_
{
    public class NewContacts
    {
        CreateContacts obj = new CreateContacts();
        public void newContacts()
        {
            Console.WriteLine("Enter the number of contacts You want to add");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 1; i<=num;i++)
            {
                obj.CreateContactMethod();
            }
        }
        public void printcont()
        {
            foreach(var a in obj.ContactBook)
            {
                Console.WriteLine();
                Console.WriteLine("FirstName is "+ a.firstName);
                Console.WriteLine("LastName is "+ a.lastName);
                Console.WriteLine("Address is "+ a.address);
                Console.WriteLine("City is " + a.city);
                Console.WriteLine("State is "+ a.state);
                Console.WriteLine("Zip is "+ a.zip);
                Console.WriteLine("PhoneNumber is "+ a.phone);
                Console.WriteLine("Email is "+a.email);
                
            }
        }
        
    }
}

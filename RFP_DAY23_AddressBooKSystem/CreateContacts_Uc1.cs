using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY_23_ADDRESSBOOK_Lambda_
{
    public class CreateContacts
    {
       public List<Contacts> ContactBook = new List<Contacts>();
       public void CreateContactMethod()
        {
            Contacts obj = new Contacts();
            Console.WriteLine("\nEnter FirstName");
            obj.firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            obj.lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            obj.address= Console.ReadLine();
            Console.WriteLine("Enter City");
            obj.city= Console.ReadLine();   
            Console.WriteLine("Enter State");
            obj.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            obj.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            obj.phone= Console.ReadLine();
            Console.WriteLine("Enter Email");
            obj.email= Console.ReadLine();  
            ContactBook.Add(obj);
        }

        public void print()
        {
            Console.WriteLine();
            foreach (var ele in ContactBook)
            {
                Console.WriteLine("FirstName : "+ele.firstName);
                Console.WriteLine("LastName : " + ele.lastName);
                Console.WriteLine("Address : "+ele.address);
                Console.WriteLine("City : "+ ele.city);
                Console.WriteLine("State : "+ ele.state);
                Console.WriteLine("Zip : "+ ele.zip);
                Console.WriteLine("PhoneNumber : "+ ele.phone);
                Console.WriteLine("Email : " + ele.email);
            }
        }

    }
}

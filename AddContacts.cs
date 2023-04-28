using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddContacts
    {
        private List<CreateContacts> contacts = new List<CreateContacts>();
        public void AddContact(CreateContacts contact)
        {
            contacts.Add(contact);
        }
        public void DisplayAllContacts()
        {
            Console.WriteLine("\nAll Contacts:");
            foreach (CreateContacts contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                Console.WriteLine(contact.Address);
                Console.WriteLine($"{contact.City}, {contact.State} {contact.ZipCode}");
                Console.WriteLine($"Phone: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine();
            }
        }

    }
}

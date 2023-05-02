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
        public void EditContact(string firstName, string lastName)
        {
            CreateContacts contact = contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);

            if (contact == null)
            {
                Console.WriteLine($"Contact {firstName} {lastName} not found");
                return;
            }

            Console.WriteLine("Enter new contact information:");

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("City: ");
            contact.City = Console.ReadLine();
            Console.Write("State: ");
            contact.State = Console.ReadLine();
            Console.Write("Zip Code: ");
            contact.ZipCode = Console.ReadLine();
            Console.Write("Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            contact.Email = Console.ReadLine();


            Console.WriteLine("Contact updated successfully.");
        }
        public void DeleteContact(string firstName, string lastName)
        {
            CreateContacts contactToDelete = null;

            foreach (CreateContacts contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    contactToDelete = contact;
                    break;
                }
            }

            if (contactToDelete == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            contacts.Remove(contactToDelete);
            Console.WriteLine("Contact deleted successfully.");
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

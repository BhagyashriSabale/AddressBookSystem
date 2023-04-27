namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System Problem");

            List<CreateContacts> contacts = new List<CreateContacts>();

            
            Console.WriteLine("Enter contact information:");
            CreateContacts newContact = new CreateContacts();
            Console.Write("First Name: ");
            newContact.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            newContact.LastName = Console.ReadLine();
            Console.Write("Address: ");
            newContact.Address = Console.ReadLine();
            Console.Write("City: ");
            newContact.City = Console.ReadLine();
            Console.Write("State: ");
            newContact.State = Console.ReadLine();
            Console.Write("Zip Code: ");
            newContact.ZipCode = Console.ReadLine();
            Console.Write("Phone Number: ");
            newContact.PhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            newContact.Email = Console.ReadLine();
            contacts.Add(newContact);

            // Display all contacts
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

            Console.ReadLine();
        }
    }
}
namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System Problem");

            AddContacts addContacts = new AddContacts();

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
            addContacts.AddContact(newContact);

            addContacts.DisplayAllContacts();

            Console.WriteLine("Enter the name of the contact to edit:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            addContacts.EditContact(firstName, lastName);

            addContacts.DisplayAllContacts();

            Console.ReadLine();
        }
    }
}
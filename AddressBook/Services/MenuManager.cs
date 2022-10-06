using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Models;

namespace AddressBook.Services
{
    internal class MenuManager
    {
        // new inctance of a contact person 
        public List<Contactperson> contacts = new List<Contactperson>();

        public void Create()
        {
            var contactperson = new Contactperson();
            Console.WriteLine("#### SKAPA EN KONTAKTPERSON ####");
            Console.WriteLine("ANGE FÖRNAMN: ");
            contactperson.FirstName = Console.ReadLine(); 
            Console.WriteLine("ANGE EFTERNAMN: ");
            contactperson.LastName = Console.ReadLine();
            Console.WriteLine("ANGE EMAIL: ");
            contactperson.Email = Console.ReadLine();
            Console.WriteLine("ANGE ADRESS: ");
            contactperson.Adress = Console.ReadLine();
            contacts.Add(contactperson);
        }
        public void Listcontact()
        {
            foreach (var contact in contacts)
                Console.WriteLine($"{contact.Id} - {contact.FirstName} {contact.LastName}");
            Console.ReadKey();
        }

        public void MenuOptions()
        {
            Console.WriteLine("#### ADRESSBOKEN ####");
            Console.WriteLine("1. Skapa ny kontakt");
            Console.WriteLine("2. Visa adressboken");
            Console.WriteLine("3. Visa detaljerad information");
            Console.WriteLine("4. Updatera en kontakt");
            Console.WriteLine("5. Ta bort en kontakt");

            switch (Console.ReadLine())
            {
                case "1":
                    Create();
                    break;

                case "2":
                    Listcontact();
                    break;

                case "3":
                    ShowDetails();
                    break;

                case "4":
                    UpdateContact();
                    break;

                case "5":
                    DeleteContact();
                    break;

            }
            Console.ReadKey();
        }

        public void ShowDetails()
        {
            Console.Write("Ange Id på den du vill detaljerad information för: ");
            var id = Guid.Parse(Console.ReadLine());
            var contact = contacts.FirstOrDefault(x => x.Id == id);

            Console.WriteLine($"Förnamn: {contact.FirstName}");
            Console.WriteLine($"Efternamn: {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Adress: {contact.Adress}");
        }

        public void UpdateContact()
        {
            Console.Write("Ange Id på den du vill uppdatera: ");
            var id = Guid.Parse(Console.ReadLine());
            var contact = contacts.FirstOrDefault(x => x.Id == id);

            Console.Write("Förnamn: ");
            var firstName = Console.ReadLine();
            if (!string.IsNullOrEmpty(firstName))
                contact.FirstName = firstName;
            
            Console.Write("Efter Namn: ");
            var lastname = Console.ReadLine();
            if (!string.IsNullOrEmpty(lastname))
                contact.LastName = lastname;
            
            Console.Write("Email: ");
            var email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email))
                contact.Email = email;
            
            Console.Write("Adress: ");
            var Adress = Console.ReadLine();
            if (!string.IsNullOrEmpty(Adress))
                contact.Adress = Adress;




        }

        public void DeleteContact()
        {
            Console.Write("Ange Id på den du vill ta bort: ");
            var id = Guid.Parse(Console.ReadLine());
            var contact = contacts.FirstOrDefault(x => x.Id == id);
            contacts.Remove(contact);

            
        }

    }
}

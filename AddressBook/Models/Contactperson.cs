using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    internal class Contactperson
    {
        public Contactperson()
        {
            Id = Guid.NewGuid();
            FirstName = null!;
            LastName = null!;
            Email = null!;
        }
        public Contactperson(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Adress { get; set; } = null!;

    }
}

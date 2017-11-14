using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Contact
    {
        private const int Personal = 0;
        private const int Business = 1;

        private Person _person;
        private PhoneNumber _number;
        private int _contactType;


        public Contact(string firstName, string lastName, string phoneNumber, int type)
        {
            _person = new Person(firstName, lastName);
            _number = new PhoneNumber(phoneNumber);
            _contactType = type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Contact("Maya", "Roy", "6470040004", 0);
            List<Contact> allContacts = new List<Contact>();
            allContacts.Add(person1);
        }
    }
}

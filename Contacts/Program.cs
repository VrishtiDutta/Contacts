using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Contact
    {
        //Represents whether the contact is personal or business contact
        private bool _isPersonal;

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }

        public Contact(bool personalContact)
        {
            _isPersonal = personalContact;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Contact(true)
            {
                FirstName = "Maya",
                LastName = "Roy",
                PhoneNumber = "6470040004"
            };

            List<Contact> allContacts = new List<Contact>();
            allContacts.Add(person1);
        }
    }
}

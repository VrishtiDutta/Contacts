using System;
using System.Collections.Generic;

namespace Contacts
{
    class ContactBook
    {
        private List<Contact> allContacts = new List<Contact>();

        public void AddContact(string firstName, string lastName, string phoneNumber, ContactType type)
        {
            allContacts.Add(Contact.CreateContact(firstName, lastName, phoneNumber, type));
        }

        public Contact GetContact(string firstName, string lastName)
        {
            foreach (var contact in allContacts)
            {
                if (contact.Equals(new Person(firstName, lastName)))
                    return contact;
            }
            return null;
        }
    }
}

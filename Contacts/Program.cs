using System.Collections.Generic;

namespace Contacts
{
    public enum ContactType { Personal, Business }

    internal class Contact
    {
        private Person _person;
        private PhoneNumber _number;

        protected Contact(string firstName, string lastName, string phoneNumber)
        {
            _person = new Person(firstName, lastName);
            _number = new PhoneNumber(phoneNumber);
        }


        public static Contact CreateContact(string firstName, string lastName, string phoneNumber, ContactType type)
        {
            switch (type)
            {
                case ContactType.Personal:
                {
                    return new Personal(firstName, lastName, phoneNumber);
                }
                case ContactType.Business:
                {
                    return new Business(firstName, lastName, phoneNumber);
                }
            }
            return null;
        }
    }

    internal class Personal : Contact
    {
        public Personal(string firstName, string lastName, string phoneNumber) : base(firstName, lastName, phoneNumber) { }

    }

    internal class Business : Contact
    {
        public Business(string firstName, string lastName, string phoneNumber) : base(firstName, lastName, phoneNumber) { }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            var person1 = Contact.CreateContact("Maya", "Roy", "6470040004", ContactType.Personal);
            List<Contact> allContacts = new List<Contact> { person1 };
        }
    }
}

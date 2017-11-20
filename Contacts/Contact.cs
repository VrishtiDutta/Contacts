using System;
namespace Contacts
{
    public class Contact
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

        public override bool Equals(object obj)
        {
            var personToCompare = obj as Person;
            return (personToCompare != null) &&
                (String.Compare(personToCompare.GetName(), _person.GetName(), StringComparison.OrdinalIgnoreCase) == 0);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_person.GetName()}: {_number.GetNumber()}";
        }
    }
}

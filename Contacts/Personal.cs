using System;
namespace Contacts
{
    class Personal : Contact
    {
        public Personal(string firstName, string lastName, string phoneNumber) : 
                base(firstName, lastName, phoneNumber) { }

    }
}

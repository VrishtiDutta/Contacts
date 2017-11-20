using System;
namespace Contacts
{
    class Business : Contact
    {
        public Business(string firstName, string lastName, string phoneNumber) : 
                base(firstName, lastName, phoneNumber) { }
    }
}

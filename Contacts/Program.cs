using System;
using System.Collections.Generic;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new ContactBook();
            contacts.AddContact("Maya", "Roy", "6470040004", ContactType.Personal);
        }
    }
}

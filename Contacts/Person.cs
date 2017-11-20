using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Person
    {
        private String _firstName;
        private String _lastName;

        public Person(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        public String GetName()
        {
            return _firstName + " " + _lastName;
        }
    }
}

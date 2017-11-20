using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class PhoneNumber
    {
        private String _areaCode;
        private String _number;

        public PhoneNumber(string number)
        {
            _number = number;
            _areaCode = number.Substring(0, 3);
        }

        public string GetNumber()
        {
            return _number;
        }

        public string GetAreaCode()
        {
            return _areaCode;
        }
    }
}

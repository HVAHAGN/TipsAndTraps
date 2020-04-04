using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEmptyNull_01.BLL
{
    class EmployeeProductivityFormatProvider : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            int rating = (int)arg;
            if (rating==0)
            {
                return $"{rating} new employee.";
            }
            else if (rating > 0)
            {
                return $"{rating} good employee.";
            }

            return $"{rating} bad employee."; ;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType==typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }
    }
}

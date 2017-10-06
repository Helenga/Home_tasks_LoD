using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CarRentalException : ApplicationException
    {
        public CarRentalException() { }

        public CarRentalException(string message) : base(message) { }
    }
}

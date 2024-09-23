using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    class MyCustomExceptions : ApplicationException
    {
        public MyCustomExceptions() : base("Incorrect form input") 
        { 

        }
        public MyCustomExceptions(string message) : base(message) { }

        public MyCustomExceptions(string message,  Exception innerException) : base(message, innerException) { }
    }
}

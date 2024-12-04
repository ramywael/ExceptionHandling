using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class LocationException : Exception
    {
        public LocationException(string location,string message) : base(message)
        {
            Location = location;
        }

        public string Location { get; set; }

    }
}

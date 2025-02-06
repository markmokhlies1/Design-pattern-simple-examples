using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeShallowCopy
{
    public class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public Address Clone()
        {
            return new Address { City = City, Street = Street };
        }
    }
}

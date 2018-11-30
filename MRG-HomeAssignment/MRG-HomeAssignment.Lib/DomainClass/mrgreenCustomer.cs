using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRG_HomeAssignment.Lib.DomainClass
{
    public class mrgreenCustomer
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Street { get; set; }

        public int PostalCode { get; set; }

        public string City { get; set; }

        public long PersonalNumber { get; set; }
    }
}

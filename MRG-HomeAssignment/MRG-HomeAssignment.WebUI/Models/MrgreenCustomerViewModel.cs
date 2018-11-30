using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MRG_HomeAssignment.WebUI.Models
{
    public class MrgreenCustomerViewModel
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
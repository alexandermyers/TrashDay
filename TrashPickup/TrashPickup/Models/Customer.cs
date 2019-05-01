using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string AddressStreet { get; set; }
        public string AddressZip { get; set; }
        public string AddressCity { get; set; }
    }
}
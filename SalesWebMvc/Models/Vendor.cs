using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Localization { get; set; }

        public Vendor()
        {

        }

        public Vendor(int id, string name, string email, string localization)
        {
            Id = id;
            Name = name;
            Email = email;
            Localization = localization;
        }
    }
}

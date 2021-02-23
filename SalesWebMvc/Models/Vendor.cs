using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SalesWebMvc.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]

        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]

        public string Email { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
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

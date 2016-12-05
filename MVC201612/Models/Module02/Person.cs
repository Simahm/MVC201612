using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC201612.Models.Module02
{
    public partial class Person
    {
        public int IdPerson { get; set; }

        [Required]
        [Display(Name = "Persons name")]
        public string Name { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        [Range(60, 250, ErrorMessage = "Wrong...")]
        public int Height { get; set; }

        [DataType("Date")]
        public DateTime Birth { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC201612.Models.Module02
{
    [MetadataType(typeof(PersonMeta))]
    public partial class Person
    {
        public string CityCountry()
        {
            return this.City + ", " + this.Country;
        }
    }

    public class PersonMeta
    {
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Wrong city")]
        [Display(Name = "The country...")]
        public string Country { get; set; }

    }
}
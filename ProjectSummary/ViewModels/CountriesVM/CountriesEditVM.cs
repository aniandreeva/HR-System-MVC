using ProjectSummary.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectSummary.ViewModels.CountriesVM
{
    public class CountriesEditVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Please input a name!")]
        [StringLength(80,MinimumLength =3, ErrorMessage ="Min Legnth is 3")]
        [RegularExpression(@"^([A-z -]+)$", ErrorMessage = "Name can consist of letters, spaces and dashes only!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input a population!")]
        [Range(10, int.MaxValue)]
        public int Population { get; set; }

        [Required(ErrorMessage = "Please input a foundation date!")]
        [DataType(DataType.Date)]
        [Display(Name ="Foundation Date")]
        public DateTime FoundationDate { get; set; }
    }
}
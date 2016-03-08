using ProjectSummary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectSummary.ViewModels.TeamsVM
{
    public class TeamsEditVM: ListVM
    {
        public int ID { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Minimum length is 3 and maximum length is 80")]
        [RegularExpression(@"^([A-z.-_]+)$", ErrorMessage = "Username can consist of letters, dashes and underscores only!")]
        public string Name { get; set; }
    }
}
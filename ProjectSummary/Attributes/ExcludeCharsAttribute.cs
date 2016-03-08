using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectSummary.Attributes
{
    public class ExcludeCharsAttribute: ValidationAttribute
    {
        private string chars;

        public ExcludeCharsAttribute(string chars)
        {
            this.chars = chars;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                foreach (var c in this.chars)
                {
                    if (value.ToString().Contains(c))
                    {
                        return new ValidationResult("untry name contains specials symbols!");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
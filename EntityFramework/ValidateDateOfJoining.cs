using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ValidateDateOfJoining : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime dt = Convert.ToDateTime(value);
            if (dt.Year >= 2002 && dt.Year <= 2005)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "Year of Birth must be between 2002 and 2005.");


        }
    }
}

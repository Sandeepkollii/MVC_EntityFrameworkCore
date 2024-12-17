using System.ComponentModel.DataAnnotations;

namespace MVC_EntityFrameworkCore.Models
{
    public class ValidateYearOfBirth : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime dt = Convert.ToDateTime(value);
            if (dt <= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Date of Joining must be less than or equal to the current date.");
        }
    }
}

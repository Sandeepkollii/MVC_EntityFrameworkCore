using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MVC_EntityFrameworkCore.Models
{
    public class Employee
    {

        [Required(ErrorMessage = "ID is required.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "ID must be numeric.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[A-Za-z\s]{15,}$", ErrorMessage = "Name must be at least 15 characters long and contain only alphabets and spaces.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [ValidateYearOfBirth]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Date of Joining is required.")]
        [ValidateDateOfJoining]
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [Range(12000, 60000, ErrorMessage = "Salary must be between 12,000 and 60,000.")]
        public decimal? Salary { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        [RegularExpression(@"^(HR|Accts|IT)$", ErrorMessage = "Department must be HR, Accts, or IT.")]
        public string Dept { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}



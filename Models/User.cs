using System.ComponentModel.DataAnnotations;
namespace CustomValidationDemo.Models;
public class User
{
    [Required]
    [MinLength(3, ErrorMessage = "At least 3 characters required for FirstName")]
    public string FirstName { get; set; }
    [Required]
    [MinLength(3, ErrorMessage = "At least 3 characters required for LastName")]
    public string LastName { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }
    [Required]
    [Range(18, 100, ErrorMessage = "Age must be between 18 to 100")]
    public int Age { get; set; }
}


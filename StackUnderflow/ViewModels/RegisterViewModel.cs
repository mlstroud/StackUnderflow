using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [Display(Name = "Username")]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "Sorry, your passwords did not match")]
    public string ConfirmPassword { get; set; }
  }
}
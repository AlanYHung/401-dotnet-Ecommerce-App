using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_App.Auth.Model.Dto
{
  public class RegisterUser
  {
    [Required]
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<string> Roles { get; set; }
  }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Realtors.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите логин"), Description("User")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите пароль"), Description("Password")]
        public string Password { get; set; }
    }
}
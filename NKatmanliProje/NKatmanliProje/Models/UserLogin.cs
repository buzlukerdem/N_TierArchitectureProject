using System.ComponentModel.DataAnnotations;

namespace NKatmanliProje.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Lütfen emailinizi girin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}

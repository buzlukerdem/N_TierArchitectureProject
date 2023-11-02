using System.ComponentModel.DataAnnotations;

namespace NKatmanliProje.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı girin")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }


    }


}





using System.ComponentModel.DataAnnotations;

namespace NKatmanliProje.Models
{
    public class UserEditModel
    {
        [Required(ErrorMessage = "Lütfen isim alanını boş geçmeyin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim alanını boş geçmeyin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen e-mail alanını boş geçmeyin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet alanını boş geçmeyin")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen şifre alanını boş geçmeyin")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        public string ConfirmPassword { get; set; }
    }
}

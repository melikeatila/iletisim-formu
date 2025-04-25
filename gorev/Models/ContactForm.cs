using System.ComponentModel.DataAnnotations;

namespace gorev.Models
{
    public class ContactForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunludur.")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "E-Posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string EPosta { get; set; }

        [Required(ErrorMessage = "Departman seçimi zorunludur.")]
        public string Departman { get; set; }
        public string? Mesaj { get; set; }
    }
}

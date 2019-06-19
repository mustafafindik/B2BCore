using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models.Identity
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Mail Alanı Zorunludur.")]
        [EmailAddress]
        [Display(Name = "Mail Adresi")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmedi")]
        public string ConfirmPassword { get; set; }
    }
}

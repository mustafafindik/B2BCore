using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models.Identity
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şimdiki Şifre")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Şifre En Az 6 Karakter Uzunluğunda Olmalı.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni Şifre")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Yeni Şifre Tekrar")]
        [Compare("NewPassword", ErrorMessage = "Şifreler Eşleşmedi")]
        public string ConfirmPassword { get; set; }

    }
}

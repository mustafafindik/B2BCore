using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models.Identity
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Mail Alanı Zorunludur.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}

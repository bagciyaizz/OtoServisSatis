﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.WebUI.Models
{
    public class CustomerLoginViewModel
    {

        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Email { get; set; }
        [Display(Name = "Şifre"), StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Sifre { get; set; }
    }
}

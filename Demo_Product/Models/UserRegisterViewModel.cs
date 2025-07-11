﻿using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim değeri giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim değeri giriniz.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen mailinizi giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen tekrar şifre giriniz.")]
        [Compare("Password", ErrorMessage ="Lütfen şifrelerin eşleştiğinden emin olun.")]
        public string ConfirmPassword { get; set; }

    }
}

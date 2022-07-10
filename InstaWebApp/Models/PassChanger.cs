using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace InstaWebApp.Models
{
    public class PassChanger
    {
        public int id { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage ="please enter {0}. it shouldn't be null.")]
        [MaxLength(200,ErrorMessage ="you can't use upper than {1} for {0}")]
        public string Password { get; set; }
        [Required(ErrorMessage = "please enter {0}. it shouldn't be null.")]
        [MaxLength(200, ErrorMessage = "you can't use upper than {1} for {0}")]
        [Compare("Password",ErrorMessage ="it's not equal with Password")]
        public string ConfirmPassword { get; set; }
    }
}
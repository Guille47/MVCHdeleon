using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHdeleon.Models.ViewModel
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage ="El {0} deve de tener al menos {1} caracteres", MinimumLength = 1)]
        [Display(Name ="Correo Electronico")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Clave")]
        public string Password { get; set; }
        [Display(Name ="Confirmar clave")]
        [Compare("Password", ErrorMessage ="Las claves no son iguales")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name ="Edad")]
        public int Edad { get; set; }
    }    
    public class EditUserViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage ="El {0} deve de tener al menos {1} caracteres", MinimumLength = 1)]
        [Display(Name ="Correo Electronico")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Clave")]
        public string Password { get; set; }
        [Display(Name ="Confirmar clave")]
        [Compare("Password", ErrorMessage ="Las claves no son iguales")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name ="Edad")]
        public int Edad { get; set; }
    }
}
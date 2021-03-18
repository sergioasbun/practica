using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practica.Models
{
    public class asbun
    {
        public enum Departamentos
        {
            Santa_Cruz = 1,
            Cochabamba = 2,
            La_Paz = 3,
            Oruro = 4,
        }
        [key]
        public int asbunID { get; set; }
        public string friendofasbun { get; set; }
        [required]
        [Display(Name = "nombre completo ")]
        [StringLength(24, MinimumLength = 2)]
        public string Friendofasbun { get; set; }
        [Required]
        public Departamentos Place { get; set; }
        [EmailAddress()]
        public string Email { get; set; }
        {DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")} 
        public DateTime Birthdate { get; set;}

    }
}
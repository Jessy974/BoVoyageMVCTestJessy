using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public class Client : Personne
    {
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                          @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
       ErrorMessage = "L'adresse mail n'est pas au bon format")]
        public string Email { get; set; }

    }
}
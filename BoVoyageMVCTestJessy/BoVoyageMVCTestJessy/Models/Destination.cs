using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public class Destination : BaseModel
    {
        [Display(Name = "Continent")]
        [StringLength(50, MinimumLength = 2,
         ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Continent { get; set; }

        [Display(Name = "Pays")]
        [StringLength(50, MinimumLength = 2,
        ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Pays { get; set; }

        [Display(Name = "Region")]
        [StringLength(50, MinimumLength = 2,
        ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Region { get; set; }

        [Display(Name ="Description")]
        public string Description { get; set; }

    }
}
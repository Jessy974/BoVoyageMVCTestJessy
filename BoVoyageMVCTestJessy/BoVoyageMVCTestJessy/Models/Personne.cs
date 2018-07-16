using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public abstract class Personne : BaseModel
    {
        public string Civilite { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [Display(Name ="Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire")]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire")]
        [Display(Name = "Adresse")]
        [StringLength(250, MinimumLength = 2,
         ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le champ{0} est obligatoire")]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime DateDeNaissance { get; set; }

        [NotMapped]
        public int Age { get; set; }
    }
}
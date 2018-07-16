using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public class Voyage : BaseModel
    {
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Date Aller")]
        [DataType(DataType.Date)]
        public DateTime DateAller { get; set; }


       
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Date Retour")]
        [DataType(DataType.Date)]
        public DateTime DateRetour { get; set; }


        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Places disponibles")]
        public int PlacesDisponibles { get; set; }


        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Display(Name = "Tarif tout compris")]
        public decimal TarifToutCompris { get; set; }

      
        public int IDDestination { get; set; }

        [ForeignKey("IDDestination")]
        public Destination Destination { get; set; }


       
        public int IDAgence { get; set; }

        [ForeignKey("IDAgence")]
        public Agence Agence { get; set; }


    }
}
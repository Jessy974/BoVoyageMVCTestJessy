using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public class Reservation : BaseModel
    {
        [Required(ErrorMessage = "Le numéro de carte bancaire est obligatoire")]
        [DataType(DataType.CreditCard)]
        public string NumeroCarteBancaire { get; set; }

        public decimal PrixTotal { get; set; }

        
        public int IDClient { get; set; }

        [ForeignKey("IDClient")]
        public Client Client { get; set; }

       
        public int IDVoyage { get; set; }

        [ForeignKey("IDVoyage")]
        public Voyage Voyage { get; set; }

        public int IDAssurance { get; set; }

        [ForeignKey("IDAssurance")]
        public Assurance Assurance{ get; set; }

    }
}
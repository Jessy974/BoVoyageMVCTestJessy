using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public class Assurance :BaseModel
    {
        [Display(Name ="Assurance Annulation")]
        public bool AssuranceAnnulation { get; set; }
     
    }
}
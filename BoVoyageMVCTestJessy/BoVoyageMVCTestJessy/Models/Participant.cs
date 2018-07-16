using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Models
{
    public class Participant : Personne
    {

        public int IDReservation { get; set; }

        [ForeignKey("IDReservation")]
        public Reservation Reservation { get; set; }

    }
}
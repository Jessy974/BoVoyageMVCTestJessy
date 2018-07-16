using BoVoyageMVCTestJessy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Data
{
    public class BoVoyageMVCTestJessyDbContext : DbContext
    {
        public BoVoyageMVCTestJessyDbContext() : base("Jess")
        {
           
        }

        public DbSet<Agence> Agences { get; set; }

        public DbSet<Assurance> Assurances { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Voyage> Voyages { get; set; }
    }
}
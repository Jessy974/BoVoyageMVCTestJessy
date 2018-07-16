using BoVoyageMVCTestJessy.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestJessy.Migrations
{
    public class Configuration : DbMigrationsConfiguration<BoVoyageMVCTestJessyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}
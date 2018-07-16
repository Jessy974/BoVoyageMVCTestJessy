namespace BoVoyageMVCTestJessy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql:"getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Assurances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AssuranceAnnulation = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Civilite = c.String(),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Adresse = c.String(nullable: false, maxLength: 250),
                        Telephone = c.String(nullable: false),
                        DateDeNaissance = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Continent = c.String(maxLength: 50),
                        Pays = c.String(maxLength: 50),
                        Region = c.String(maxLength: 50),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDReservation = c.Int(nullable: false),
                        Civilite = c.String(),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Adresse = c.String(nullable: false, maxLength: 250),
                        Telephone = c.String(nullable: false),
                        DateDeNaissance = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reservations", t => t.IDReservation, cascadeDelete: true)
                .Index(t => t.IDReservation);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeroCarteBancaire = c.String(nullable: false),
                        PrixTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IDClient = c.Int(nullable: false),
                        IDVoyage = c.Int(nullable: false),
                        IDAssurance = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Assurances", t => t.IDAssurance, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.IDClient, cascadeDelete: true)
                .ForeignKey("dbo.Voyages", t => t.IDVoyage, cascadeDelete: true)
                .Index(t => t.IDClient)
                .Index(t => t.IDVoyage)
                .Index(t => t.IDAssurance);
            
            CreateTable(
                "dbo.Voyages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateAller = c.DateTime(nullable: false),
                        DateRetour = c.DateTime(nullable: false),
                        PlacesDisponibles = c.Int(nullable: false),
                        TarifToutCompris = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IDDestination = c.Int(nullable: false),
                        IDAgence = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getDate()"),
                        Deleted = c.Boolean(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Agences", t => t.IDAgence, cascadeDelete: true)
                .ForeignKey("dbo.Destinations", t => t.IDDestination, cascadeDelete: true)
                .Index(t => t.IDDestination)
                .Index(t => t.IDAgence);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "IDReservation", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "IDVoyage", "dbo.Voyages");
            DropForeignKey("dbo.Voyages", "IDDestination", "dbo.Destinations");
            DropForeignKey("dbo.Voyages", "IDAgence", "dbo.Agences");
            DropForeignKey("dbo.Reservations", "IDClient", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "IDAssurance", "dbo.Assurances");
            DropIndex("dbo.Voyages", new[] { "IDAgence" });
            DropIndex("dbo.Voyages", new[] { "IDDestination" });
            DropIndex("dbo.Reservations", new[] { "IDAssurance" });
            DropIndex("dbo.Reservations", new[] { "IDVoyage" });
            DropIndex("dbo.Reservations", new[] { "IDClient" });
            DropIndex("dbo.Participants", new[] { "IDReservation" });
            DropTable("dbo.Voyages");
            DropTable("dbo.Reservations");
            DropTable("dbo.Participants");
            DropTable("dbo.Destinations");
            DropTable("dbo.Clients");
            DropTable("dbo.Assurances");
            DropTable("dbo.Agences");
        }
    }
}

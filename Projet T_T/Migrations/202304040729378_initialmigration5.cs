namespace Projet_T_T.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "terrain_id", "dbo.Terrains");
            DropIndex("dbo.Reservations", new[] { "terrain_id" });
            AddColumn("dbo.Reservations", "terrain", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "datePaiement");
            DropColumn("dbo.Reservations", "terrain_id");
            DropTable("dbo.Terrains");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Terrains",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        nom = c.String(),
                        prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Reservations", "terrain_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Reservations", "datePaiement", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "terrain");
            CreateIndex("dbo.Reservations", "terrain_id");
            AddForeignKey("dbo.Reservations", "terrain_id", "dbo.Terrains", "id");
        }
    }
}

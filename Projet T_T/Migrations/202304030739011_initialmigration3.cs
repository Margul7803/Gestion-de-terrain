namespace Projet_T_T.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "datePaiement", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "datePaiement");
        }
    }
}

namespace Projet_T_T.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "nom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "nom", c => c.String());
        }
    }
}

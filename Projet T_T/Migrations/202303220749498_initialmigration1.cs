﻿namespace Projet_T_T.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "dateFinAbo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "dateFinAbo");
        }
    }
}

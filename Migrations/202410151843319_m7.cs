﻿namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m7 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Destinations");
            AlterColumn("dbo.Destinations", "DestinationId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Destinations", "DestinationId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Destinations");
            AlterColumn("dbo.Destinations", "DestinationId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Destinations", "DestinationId");
        }
    }
}

namespace HomeComingMVCFall18.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVenueClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Venue",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Setting = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Activity", "VenueId");
            AddForeignKey("dbo.Activity", "VenueId", "dbo.Venue", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activity", "VenueId", "dbo.Venue");
            DropIndex("dbo.Activity", new[] { "VenueId" });
            DropTable("dbo.Venue");
        }
    }
}

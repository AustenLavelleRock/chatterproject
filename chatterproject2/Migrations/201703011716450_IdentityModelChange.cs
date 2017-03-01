namespace chatterproject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityModelChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewChats",
                c => new
                    {
                        ChatID = c.Int(nullable: false, identity: true),
                        Chatter = c.String(),
                        Date = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ChatID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewChats", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.NewChats", new[] { "ApplicationUser_Id" });
            DropTable("dbo.NewChats");
        }
    }
}

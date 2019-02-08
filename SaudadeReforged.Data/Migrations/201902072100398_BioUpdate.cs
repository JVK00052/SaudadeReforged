namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BioUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bio",
                c => new
                    {
                        BioId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        FullName = c.String(nullable: false),
                        NickNames = c.String(),
                        Birthday = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Location = c.String(),
                        Race = c.String(),
                        Ethnicity = c.String(),
                        AboutYou = c.String(nullable: false),
                        Interests = c.String(),
                        Hobbies = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.BioId);
            
            DropColumn("dbo.ApplicationUser", "FirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplicationUser", "FirstName", c => c.String());
            DropTable("dbo.Bio");
        }
    }
}

namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCharacterUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entry", "Title", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Entry", "Topic", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Entry", "Tag", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entry", "Tag", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Entry", "Topic", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Entry", "Title", c => c.String(nullable: false, maxLength: 20));
        }
    }
}

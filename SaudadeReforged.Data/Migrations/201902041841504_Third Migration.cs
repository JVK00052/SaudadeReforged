namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entry", "Topic", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Entry", "Tag", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Entry", "Title", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entry", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Entry", "Tag");
            DropColumn("dbo.Entry", "Topic");
        }
    }
}

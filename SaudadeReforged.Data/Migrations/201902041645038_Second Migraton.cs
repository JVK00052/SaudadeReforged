namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigraton : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Entry", "Topic");
            DropColumn("dbo.Entry", "Tag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entry", "Tag", c => c.String(nullable: false));
            AddColumn("dbo.Entry", "Topic", c => c.String(nullable: false));
        }
    }
}

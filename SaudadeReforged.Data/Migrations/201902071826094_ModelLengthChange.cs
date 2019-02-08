namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelLengthChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entry", "Title", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Entry", "Topic", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Entry", "Tag", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entry", "Tag", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Entry", "Topic", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Entry", "Title", c => c.String(nullable: false, maxLength: 200));
        }
    }
}

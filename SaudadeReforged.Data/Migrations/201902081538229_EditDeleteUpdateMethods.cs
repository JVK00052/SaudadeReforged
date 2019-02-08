namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDeleteUpdateMethods : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bio");
            AlterColumn("dbo.Bio", "Bioid", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Bio", "BioId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bio");
            AlterColumn("dbo.Bio", "Bioid", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bio", "BioId");
        }
    }
}

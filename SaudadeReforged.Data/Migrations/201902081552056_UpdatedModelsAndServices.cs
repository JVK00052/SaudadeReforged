namespace SaudadeReforged.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModelsAndServices : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bio");
            AlterColumn("dbo.Bio", "BioId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bio", "BioId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bio");
            AlterColumn("dbo.Bio", "BioId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Bio", "BioId");
        }
    }
}

namespace DressBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}

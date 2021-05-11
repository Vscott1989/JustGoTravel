namespace JustGoTravel.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VacationPack", "Title", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.VacationPack", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VacationPack", "Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.VacationPack", "Title");
        }
    }
}

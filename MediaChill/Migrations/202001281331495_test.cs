namespace MediaChill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Video", c => c.String());
            DropColumn("dbo.Films", "Data");
            DropColumn("dbo.Films", "ContentType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "ContentType", c => c.String());
            AddColumn("dbo.Films", "Data", c => c.Binary());
            DropColumn("dbo.Films", "Video");
        }
    }
}

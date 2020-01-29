namespace MediaChill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        RealName = c.String(),
                        Genre = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        note = c.Int(nullable: false),
                        Compteur = c.Int(nullable: false),
                        Image = c.String(),
                        Data = c.Binary(),
                        ContentType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}

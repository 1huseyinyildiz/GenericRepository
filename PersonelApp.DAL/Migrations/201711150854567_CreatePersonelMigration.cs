namespace PersonelApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonelMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departmants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        İsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        lastName = c.String(),
                        DepartmantId = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        İsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departmants", t => t.DepartmantId, cascadeDelete: true)
                .Index(t => t.DepartmantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "DepartmantId", "dbo.Departmants");
            DropIndex("dbo.Personels", new[] { "DepartmantId" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departmants");
        }
    }
}

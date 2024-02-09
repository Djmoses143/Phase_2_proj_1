namespace DAL_layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeptMasters",
                c => new
                    {
                        DeptCode = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeptCode);
            
            CreateTable(
                "dbo.EmpProfiles",
                c => new
                    {
                        EmpCode = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        DeptCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpCode)
                .ForeignKey("dbo.DeptMasters", t => t.DeptCode, cascadeDelete: true)
                .Index(t => t.DeptCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpProfiles", "DeptCode", "dbo.DeptMasters");
            DropIndex("dbo.EmpProfiles", new[] { "DeptCode" });
            DropTable("dbo.EmpProfiles");
            DropTable("dbo.DeptMasters");
        }
    }
}

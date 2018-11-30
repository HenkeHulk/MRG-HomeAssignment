namespace MRG_HomeAssignment.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mrgreenCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Street = c.String(),
                        PostalCode = c.Int(nullable: false),
                        City = c.String(),
                        PersonalNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.redbetCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Street = c.String(),
                        PostalCode = c.Int(nullable: false),
                        City = c.String(),
                        FavoriteTeam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.redbetCustomers");
            DropTable("dbo.mrgreenCustomers");
        }
    }
}

namespace FitnessTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vouchers",
                c => new
                    {
                        VoucherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.VoucherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vouchers");
        }
    }
}

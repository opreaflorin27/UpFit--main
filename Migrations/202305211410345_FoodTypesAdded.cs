namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodTypesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodTypes",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TypeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodTypes");
        }
    }
}

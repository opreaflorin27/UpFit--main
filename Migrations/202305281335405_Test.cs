namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        foodID = c.Int(nullable: false, identity: true),
                        type = c.Int(nullable: false),
                        name = c.String(nullable: false),
                        calories = c.Double(),
                        proteins = c.Double(),
                        fats = c.Double(),
                        carbs = c.Double(),
                        fibers = c.Double(),
                        vitamin_A = c.Double(),
                        vitamin_B = c.Double(),
                        vitamin_C = c.Double(),
                        vitamin_D = c.Double(),
                        vitamin_E = c.Double(),
                    })
                .PrimaryKey(t => t.foodID);
            
            CreateTable(
                "dbo.FoodTypes",
                c => new
                    {
                        ID_Type = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Type);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        mealID = c.Int(nullable: false, identity: true),
                        mealTypeFK = c.Int(nullable: false),
                        userFK = c.Int(nullable: false),
                        foodFK = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.mealID);
            
            CreateTable(
                "dbo.MealTypes",
                c => new
                    {
                        mealTypeID = c.Int(nullable: false, identity: true),
                        mealName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.mealTypeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        SubscriptionTypeFK = c.Int(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        KcalDaily = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.MealTypes");
            DropTable("dbo.Meals");
            DropTable("dbo.FoodTypes");
            DropTable("dbo.Foods");
            DropTable("dbo.Admins");
        }
    }
}

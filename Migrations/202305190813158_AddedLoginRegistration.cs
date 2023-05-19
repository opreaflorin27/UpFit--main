namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLoginRegistration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Gender", c => c.String(nullable: false));
        }
    }
}

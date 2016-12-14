namespace MVCAuthSample.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "RoleName", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "RoleName");
        }
    }
}

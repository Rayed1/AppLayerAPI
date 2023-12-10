namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Date", c => c.DateTime(nullable: false));
        }
    }
}

using System;
using System.Data.Entity.Migrations;

namespace XNOTE.DataAccess.Migrations
{
    public partial class AddUserPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Photo");
        }
    }
}

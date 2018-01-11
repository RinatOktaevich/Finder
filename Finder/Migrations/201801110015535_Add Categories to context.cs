namespace Finder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriestocontext : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CategoryApplicationUsers", newName: "ApplicationUserCategories");
            DropPrimaryKey("dbo.ApplicationUserCategories");
            AddPrimaryKey("dbo.ApplicationUserCategories", new[] { "ApplicationUser_Id", "Category_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ApplicationUserCategories");
            AddPrimaryKey("dbo.ApplicationUserCategories", new[] { "Category_Id", "ApplicationUser_Id" });
            RenameTable(name: "dbo.ApplicationUserCategories", newName: "CategoryApplicationUsers");
        }
    }
}

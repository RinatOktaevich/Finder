namespace Finder.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Finder.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Finder.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Categories.Add(new Models.Category() { Name = "Guitaries" });
            context.Categories.Add(new Models.Category() { Name = "Piano" });

            context.Roles.Add(new IdentityRole("Admin"));
            context.Roles.Add(new IdentityRole("Client"));




            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

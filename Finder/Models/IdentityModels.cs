﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Finder.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {


        public ICollection<Category> Categories { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public ApplicationUser()
        {
            Categories = new List<Category>();
            
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("FinderDB", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new UniDBInitializer<ApplicationDbContext>());
        }

        public DbSet<Category> Categories { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        private class UniDBInitializer<T> : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
        {

            protected override void Seed(ApplicationDbContext context)
            {



                base.Seed(context);
            }

        }




    }
}
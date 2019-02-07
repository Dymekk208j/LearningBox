using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningBox.Models.DatabaseModels.DbInitializer
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            CreateUsers(context);
        }

        private void CreateUsers(ApplicationDbContext context)
        {
            UserManager<ApplicationUser> userManager =
                new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            ApplicationUser user = new ApplicationUser
            {
                UserName = "Dymek",
                Blocked = false,
                Email = "Kontakt@damiandziura.pl",
            };
            
            userManager.Create(user, "Damian13!");

            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }

            userManager.AddToRole(user.Id, "Admin");
        }
    }


}
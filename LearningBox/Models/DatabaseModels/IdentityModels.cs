using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningBox.Models.DatabaseModels
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }

        [Display(Name = "Blocked")]
        public bool Blocked { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.CommandTimeout = 900;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       // public virtual DbSet<TeamType> TeamTypes { get; set; }


        public new virtual int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
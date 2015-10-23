using System;
using System.Data.Entity.Core.EntityClient;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Azure;

namespace aspmvc4azure.web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        private ApplicationDbContext(String connectionString)
            :base(connectionString, throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {

            var c = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = CloudConfigurationManager.GetSetting("azuresql"),
                Metadata = @"res://*/ALFModel.csdl|res://*/ALFModel.ssdl|res://*/ALFModel.msl"
            };

            //EntityConnection 
            //return new ALFEntities(new EntityConnection(c.ToString()));
            return new ApplicationDbContext(c.ToString());
        }

        public System.Data.Entity.DbSet<Product> Products { get; set; }
    }
}
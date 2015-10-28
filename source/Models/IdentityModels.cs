// 
// Date		21-10-2015 10:08
// Author	Paul Greer
// 
// Copyright © RedPixie Ltd 2010-2014. All rights reserved.
// The software and associated documentation supplied hereunder are the 
// proprietary information of RedPixie Ltd, 145-157 St John Street, 
// London, EC1V 4PY, United Kingdom and are supplied subject to licence terms.

using System;
using System.Data.Entity.Core.EntityClient;
using System.Diagnostics;
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
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager) {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            ClaimsIdentity userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", false) {

                var cs = CloudConfigurationManager.GetSetting("DefaultConnection");
                Trace.TraceInformation("Using connection string: "+cs);
        }

        public ApplicationDbContext(String connectionString)
            : base(connectionString, false) {
        }

        public static ApplicationDbContext Create() {
//            var c = new EntityConnectionStringBuilder {
//                Provider = "System.Data.SqlClient",
//                ProviderConnectionString = CloudConfigurationManager.GetSetting("azuresql"),
//                Metadata = @"res://*/ALFModel.csdl|res://*/ALFModel.ssdl|res://*/ALFModel.msl"
//            };
//            return new ApplicationDbContext(c.ToString());

            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Product> Products { get; set; }
    }
}
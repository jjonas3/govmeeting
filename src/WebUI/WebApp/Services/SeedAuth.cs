﻿using GM.Application.Configuration;
using GM.Infrastructure.InfraCore.Data;
using GM.Infrastructure.InfraCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GM.WebUI.WebApp.Services
{
    public interface ISeedAuth
    {
        Task<bool> Seed();
    }

    public class SeedAuth : ISeedAuth
    {
        private readonly ILogger<SeedAuth> logger;

        public SeedAuth(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            //IConfiguration configuration,
            IOptions<AppSettings> config,
            ILogger<SeedAuth> _logger
            )
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            //_configuration = configuration;
            _config = config.Value;
            logger = _logger;
        }

        readonly ApplicationDbContext _context;
        readonly UserManager<ApplicationUser> _userManager;
        readonly RoleManager<IdentityRole> _roleManager;
        //IConfiguration _configuration;
        private readonly AppSettings _config;

        public async Task<bool> Seed()
        {

            // REMOVED PRIOR CODE 1 - See below

            string admin_email = _config.DbAdmin.Email;

            // If there are no users, create admin user. This adds it to the table dbo.AspNetUsers
            if (!_context.Users.Any())
            {
                string admin_username = _config.DbAdmin.Username;
                string admin_password = _config.DbAdmin.Password;

                logger.LogInformation("No users in DB. Create admin user");
                await _userManager.CreateAsync(new ApplicationUser() { UserName = admin_username, Email = admin_email, EmailConfirmed = true }, admin_password);

                ApplicationUser admin_user;
                admin_user = await _userManager.FindByEmailAsync(admin_email);

                // REMOVED PRIOR CODE 2 - See below

                // assign admin privileges. This adds an entry in table AspNetUserClaims
                var claims = await _userManager.GetClaimsAsync(admin_user);
                var jobClaim = claims.FirstOrDefault(c => c.Type == "role");
                if (jobClaim == null)
                {
                    await _userManager.AddClaimAsync(admin_user, new Claim("role", "Administrator"));
                }
            }
            else
            {
                ApplicationUser admin_user;
                admin_user = await _userManager.FindByEmailAsync(admin_email);
                if (admin_user != null)
                {
                    logger.LogInformation("Found admin user, " + admin_user.UserName + ", by email=" + admin_email);
                }
                else
                {
                    logger.LogWarning("admin user email=" + admin_email + " not found");
                }
            }

            // TODO add error handling and return success/fail
            return true;
        }
    }

}



// REMOVED PRIOR CODE 1
// The following was from before we switch to using claims.
//// Create roles. This adds them to the table dbo.AspNetRoles.
//string[] roles = new string[] { "UserManager", "StaffManager" };
//foreach (string role in roles)
//{
//    if (!await roleManager.RoleExistsAsync(role))
//    {
//        await roleManager.CreateAsync(new IdentityRole(role));
//    }
//}

// REMOVED PRIOR CODE 2
// The following was from before we switch to using claims.
//// assign admin privileges. This adds and enty in table dbo.AspNetUserRoles
//ApplicationUser admin = await userManager.FindByEmailAsync("info@example.com");
//foreach (string role in roles)
//{
//    await userManager.AddToRoleAsync(admin, role);
//}



/*      SUMMARY OF CALLS TO CREATE ENTRIES IN AUTHENTICATION TABLES
 *                   CALL                                    CREATES ENTRY IN
 * userManager.CreateAsync(new ApplicationUser() { ... }     dbo.AspNetUsers        users
 * roleManager.CreateAsync(new IdentityRole( ... ))          dbo.AspNetRoles        roles
 * userManager.AddToRoleAsync( ... )                         dbo.AspNetUserRoles    roles of users
 * userManager.AddClaimAsync(user, new Claim( ... )          dbo.AspNetUserClaims   claims of users
 *                                                           dbo.AspNetRoleClaims   claims of roles
 *                                                           dbo.AspNetUserLogins
 *                                                           dbo.AspNetUserTokens
 *
 *   
 * A claim is a name value pair that represents what the subject is, not what the subject can do.
 *
 *   https://benfoster.io/blog/asp-net-identity-role-claims/
 */

using GalaxyMedico.Services.Identity.DbContexts;
using GalaxyMedico.Services.Identity.Models;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.Identity.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationContext db,UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void Initialize()
        {
         if(_roleManager.FindByNameAsync(StaticDetails.Admin).Result==null)
            {
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.Customer)).GetAwaiter().GetResult();
            }
            else { return; }

            ApplicationUser adminUser = new ApplicationUser()
            {
                UserName = "shabanaparveen@live.com",
                Email="shabanaparveen@live.com",
                EmailConfirmed=true,
                PhoneNumber="9742958351",
                FirstName="Shabana",
                LastName="Parveen"
            };

            _userManager.CreateAsync(adminUser, "Admin#123*").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(adminUser, StaticDetails.Admin).GetAwaiter().GetResult();

           var temp1= _userManager.AddClaimsAsync(adminUser, new Claim[] {
                new Claim(JwtClaimTypes.Name,adminUser.FirstName+" "+adminUser.LastName),
                new Claim(JwtClaimTypes.GivenName,adminUser.FirstName),
                new Claim(JwtClaimTypes.FamilyName,"Ansari"),
                new Claim(JwtClaimTypes.Role,StaticDetails.Admin),
            }).Result;

            ApplicationUser customerUser = new ApplicationUser()
            {
                UserName = "shabyparveen@gmail.com",
                Email = "shabyparveen@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "35235235",
                FirstName = "Shaby",
                LastName = "Parveen"
            };

            _userManager.CreateAsync(customerUser, "Welcome#123*").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(customerUser, StaticDetails.Customer).GetAwaiter().GetResult();

            var temp2 = _userManager.AddClaimsAsync(customerUser, new Claim[] {
                new Claim(JwtClaimTypes.Name, customerUser.FirstName+" "+customerUser.LastName),
                new Claim(JwtClaimTypes.GivenName,customerUser.FirstName),
                new Claim(JwtClaimTypes.FamilyName,customerUser.LastName),
                new Claim(JwtClaimTypes.Role,StaticDetails.Customer),
            }).Result;
        }
    }
}

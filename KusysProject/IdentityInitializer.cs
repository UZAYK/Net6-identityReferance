using KUSYSDemo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace KUSYSDemo.Web
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }
            var dealerRole = await roleManager.FindByNameAsync("Dealer");
            if (dealerRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Dealer" });
            }
            var adminUser = await userManager.FindByNameAsync("uzay");
            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    UserName = "uzay",
                    Email = "uzay@gmail.com"
                };
                await userManager.CreateAsync(user, "1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}

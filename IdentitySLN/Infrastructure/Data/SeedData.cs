using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class SeedData
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Baitul",
                    Email = "baitul@test.com",
                    UserName = "baitul@test.com",
                    Address = new Address
                    {
                        FirstName = "Baitul",
                        LastName = "Amin",
                        HouseNo = "Serker Bari",
                        Street = "G.T.Road",
                        City = "Chandpur"
                    }
                };
                await userManager.CreateAsync(user, "B@itul_10");
            }
        }
    }
}

using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Realm.Data.Models
{
    public class SeedData
    {
        private ApplicationDbContext _context;

        public SeedData(ApplicationDbContext context)
        {
            _context = context;
        }

        public async void SeedAdminUser()
        {
            var user = new AppUser
            {
                FirstName = "Grant",
                LastName = "Watson",
                UserName = "Granticus",
                NormalizedUserName = "granticus",
                Email = "gwatson117@gmail.com",
                NormalizedEmail = "gwatson117@gmail.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var roleStore = new RoleStore<IdentityRole>(_context);

            if (!_context.Roles.Any(r => r.Name == "Admin"))
            {
                await roleStore.CreateAsync(new IdentityRole { Name = "Admin", NormalizedName = "Admin" });
                await roleStore.CreateAsync(new IdentityRole { Name = "Dev", NormalizedName = "Dev" });
            }

            if (!_context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<AppUser>();
                var hashed = password.HashPassword(user, "Wats#0529");
                user.PasswordHash = hashed;
                var userStore = new UserStore<AppUser>(_context);
                await userStore.CreateAsync(user);
                await userStore.AddToRoleAsync(user, "admin");
            }

            await _context.SaveChangesAsync();
        }
    }
}

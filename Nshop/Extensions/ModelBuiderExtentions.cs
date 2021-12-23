using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nshop.Extensions
{
    public static class ModelBuiderExtentions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {

            // any guid, but nothing is against to use the same one
            var roleid = new Guid("4E1CAE6D-4D76-4311-9B2A-ED8CD3EEA0E6");
            var adminid = new Guid("D8C2BEB7-0552-42FF-844D-FBC499398A37");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleid,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"

            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminid,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nguyenhuunhan1903@gmail.com",
                NormalizedEmail = "nguyenhuunhan1903@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345@"),
                SecurityStamp = string.Empty,
                FirstName = "Nhan",
                LastName = "Nguyen",
                Dob = new DateTime(2001, 03, 19)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleid,
                UserId = adminid
            });
        }
    }
}

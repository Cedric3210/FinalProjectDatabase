using Consultation.Domain;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Infrastructure.Data
{
    public class UserSeed
    {
        public static void SeedUser(ModelBuilder Builder)
        {
            var passwordHasher = new PasswordHasher<Users>();

            var appUsers = new Users
            {
                UMID = "1111111",
                Id = Guid.Parse("d7541f1e-61a6-4429-a0ae-c8e3c6d9df62").ToString(),
                UserName = "MyAccount",
                PasswordHash = passwordHasher.HashPassword(null, "Admin123!"),
                UserType = Domain.Enum.UserType.Student,

            };
            Builder.Entity<Users>().HasData(appUsers);
        }  
    }
}

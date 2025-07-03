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
        private static string UserIDStudent = "273F528F-5330-411F-9C6B-01543D6249C3";
        private static string UserIDFacutly = "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9";
        private static string UserIDAdmin = "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF";


       public static void SeedUser(ModelBuilder Builder)
        {
            var passwordHasher = new PasswordHasher<Users>();

            var studentUser = new Users
            {
                UMID = "1234",
                Id = UserIDStudent,
                UserName = "MyStudentAccount",
                UserType = Domain.Enum.UserType.Student,
                SecurityStamp = "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4",
                ConcurrencyStamp = "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b",
                Email = "MyStudentAccount.550200@umindanao.edu.ph",
                NormalizedEmail = "MYSTUDENTACCOUNT.550200@UMINDANAO.EDU.PH",
                NormalizedUserName = "MYSTUDENTACCOUNT",
                EmailConfirmed = true
            };

            
            studentUser.PasswordHash = passwordHasher.HashPassword(studentUser, "MyStudent123!");
            Builder.Entity<Users>().HasData(studentUser);

            var facultyUser = new Users
            {
                UMID = "3210",
                Id = UserIDFacutly,
                UserName = "MyFacultyaccount",
                UserType = Domain.Enum.UserType.Faculty,
                SecurityStamp = "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4",
                ConcurrencyStamp = "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b",
                Email = "MyFacultyaccount.550200@umindanao.edu.ph",
                NormalizedEmail = "MYFACULTYACCOUNT.550200@UMINDANAO.EDU.PH",
                NormalizedUserName = "MYFACULTYACCOUNT",
                EmailConfirmed = true
            };
            
            facultyUser.PasswordHash = passwordHasher.HashPassword(facultyUser, "MyFaculty123!");
            Builder.Entity<Users>().HasData(facultyUser);

            var adminUser = new Users
            {
                UMID = "4445",
                Id = UserIDAdmin,
                UserName = "MyAdminaccount",
                UserType = Domain.Enum.UserType.Admin,
                SecurityStamp = "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4",
                ConcurrencyStamp = "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b",
                Email = "MyAdminaccount.550200@umindanao.edu.ph",
                NormalizedEmail = "MYADMINACCOUNT.550200@UMINDANAO.EDU.PH",
                NormalizedUserName = "MYADMINACCOUNT",
                EmailConfirmed = true
            };
           
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "MyAdmin123!");
            Builder.Entity<Users>().HasData(adminUser);


        }  
    }
}

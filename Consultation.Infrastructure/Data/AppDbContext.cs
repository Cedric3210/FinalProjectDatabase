using Consultation.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext() : base()
        {
        }
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection to Local SQL Server Database
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=ConsultationDatabase;" +
                "Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");

            //Connection string for Azure SQL Database
            //optionsBuilder.UseSqlServer("Server=tcp:consultationserver.database.windows.net,1433;" +
            //    "Initial Catalog=ConsultationDatabaseTesting2;Persist Security Info=False;" +
            //    "User ID=ConsultationDB;Password=ServerAdmin123;" +
            //    "MultipleActiveResultSets=False;" +
            //    "Encrypt=True;" +
            //    "TrustServerCertificate=False;Connection Timeout=30;");

           optionsBuilder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var users = new List<Users>
            {
            UserSeed.UserSeeder("273F528F-5330-411F-9C6B-01543D6249C3", "1234", "MyStudentAccount", "MyStudentAccount.550200@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            UserSeed.UserSeeder("53D8F920-EBEC-4DF3-8C53-21F6D123F0D9", "3210", "MyFacultyaccount", "MyFacultyaccount.550200@umindanao.edu.ph", "MyFaculty123!", Domain.Enum.UserType.Faculty),
            UserSeed.UserSeeder("6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF", "4445", "MyAdminaccount", "MyAdminaccount.550200@umindanao.edu.ph", "MyAdmin123!", Domain.Enum.UserType.Admin),
            UserSeed.UserSeeder("D0B26692-E380-4374-985F-239B56D06C20", "547343", "UndoyBagyoUV63", "UndoyBagyo.550200@umindanao.edu.ph", "MyAdmin123!", Domain.Enum.UserType.Student),
            UserSeed.UserSeeder("1226920F-9508-44B3-845A-ABABBBCBCF5D", "6850", "MariaSantos", "mariasantos.6850@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            UserSeed.UserSeeder("0A52E15B-95E6-40FE-9110-9A44817BFF39", "8998", "JosephCruz", "josephcruz.8998@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            UserSeed.UserSeeder("78B4AF2A-672F-43C5-B819-5F0B407B7187", "7971", "AngelicaGarcia", "angelicagarcia.7971@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            UserSeed.UserSeeder("59CF8531-68E4-466B-BAEC-45305FE16A14", "9241", "MarkLopez", "marklopez.9241@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student)
            };

            var departments = new List<Department>
            {
                UserSeed.DepartmentSeeder(1, "CASE", "College of Arts and Sciences Education"),
                UserSeed.DepartmentSeeder(2, "CBAE", "College of Business Administration Education"),
                UserSeed.DepartmentSeeder(3, "CEE", "College of Engineering Education")
            };

            
            var program = new List<Program>
            {
                UserSeed.ProgramSeeder(1, "ME", "Mechanical Engineering",3),
                UserSeed.ProgramSeeder(2, "CE", "Civil Engineering",3),
                UserSeed.ProgramSeeder(3, "CPE", "Computer Engineering",3),
                UserSeed.ProgramSeeder(4, "EE", "Electrical Engineering",3),
                UserSeed.ProgramSeeder(5, "ECE", "Electronics Engineering",3),
            };

        
            var schoolYears = new List<SchoolYear>
            {
                UserSeed.schoolYearSeeder(1,"2024","2025",Domain.Enum.Semester.Semester1,Domain.Enum.SchoolYearStatus.Current),
                UserSeed.schoolYearSeeder(2,"2024","2025",Domain.Enum.Semester.Semester2,Domain.Enum.SchoolYearStatus.Current),
                UserSeed.schoolYearSeeder(3,"2024","2025",Domain.Enum.Semester.Summer,Domain.Enum.SchoolYearStatus.Current),
            };

            var enrolledCourses = new List<EnrolledCourse>()
            {
                EnrolledCourse.Seeder(1, 1, 1, 1, "ME101", "Engineering Mechanics", "3", "Lecture", "Monday", "8:00 AM - 9:30 AM", "Room 101"),
            };



            builder.Entity<Users>().HasData(users);
            builder.Entity<Department>().HasData(departments);
            builder.Entity<Program>().HasData(program);
            builder.Entity<SchoolYear>().HasData(schoolYears);
            base.OnModelCreating(builder);
        }

        public DbSet<ActionLog> ActionLog { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Bulletin> Bulletin { get; set; }
        public DbSet<ConsultationRequest> ConsultationRequest { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<EnrolledCourse> EnrolledCourse { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<SchoolYear> SchoolYear { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}

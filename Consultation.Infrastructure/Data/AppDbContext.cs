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

        private readonly SchoolYear SummerClass = DatabaseSeeder.schoolYearSeeder(1, "2024", "2025", Domain.Enum.Semester.Semester1, Domain.Enum.SchoolYearStatus.Current);
              
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
            DatabaseSeeder.UserSeeder("273F528F-5330-411F-9C6B-01543D6249C3", "550200", "Cedric Setimo", "CedricSetimo.550200@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("53D8F920-EBEC-4DF3-8C53-21F6D123F0D9", "321033", "Rey Mateo", "ReyMateo.550200@umindanao.edu.ph", "MyFaculty123!", Domain.Enum.UserType.Faculty),
            DatabaseSeeder.UserSeeder("6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF", "444533", "Raine Isid", "RaineIsid.550200@umindanao.edu.ph", "MyAdmin123!", Domain.Enum.UserType.Admin),
            DatabaseSeeder.UserSeeder("D0B26692-E380-4374-985F-239B56D06C20", "547343", "Ellaine Musni", "EllaineMusni.550200@umindanao.edu.ph", "MyAdmin123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("1226920F-9508-44B3-845A-ABABBBCBCF5D", "685043", "Reggie Soylon", "ReggieSoylon.6850@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("0A52E15B-95E6-40FE-9110-9A44817BFF39", "899812", "Cheley Balsomo", "CheleyBalsomo.8998@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student),
            DatabaseSeeder.UserSeeder("78B4AF2A-672F-43C5-B819-5F0B407B7187", "797132", "Jeanelle Labsan", "JeanelleLabsan.7971@umindanao.edu.ph", "MyFaculty123!", Domain.Enum.UserType.Faculty),
            DatabaseSeeder.UserSeeder("59CF8531-68E4-466B-BAEC-45305FE16A14", "924132", "Christopher Destajo", "ChristopherDestajo.9241@umindanao.edu.ph", "MyStudent123!", Domain.Enum.UserType.Student)
            };

            var departments = new List<Department>
            {
                DatabaseSeeder.DepartmentSeeder(1, "CASE", "College of Arts and Sciences Education"),
                DatabaseSeeder.DepartmentSeeder(2, "CBAE", "College of Business Administration Education"),
                DatabaseSeeder.DepartmentSeeder(3, "CEE", "College of Engineering Education")
            };

            
            var program = new List<Program>
            {
                DatabaseSeeder.ProgramSeeder(1, "ME", "Mechanical Engineering",3),
                DatabaseSeeder.ProgramSeeder(2, "CE", "Civil Engineering",3),
                DatabaseSeeder.ProgramSeeder(3, "CPE", "Computer Engineering",3),
                DatabaseSeeder.ProgramSeeder(4, "EE", "Electrical Engineering",3),
                DatabaseSeeder.ProgramSeeder(5, "ECE", "Electronics Engineering",3),
            };

        
            var schoolYears = new List<SchoolYear>
            {
                DatabaseSeeder.schoolYearSeeder(1,"2024","2025",Domain.Enum.Semester.Semester1,Domain.Enum.SchoolYearStatus.Current),
                DatabaseSeeder.schoolYearSeeder(2,"2024","2025",Domain.Enum.Semester.Semester2,Domain.Enum.SchoolYearStatus.Current),
                DatabaseSeeder.schoolYearSeeder(3,"2024","2025",Domain.Enum.Semester.Summer,Domain.Enum.SchoolYearStatus.Current),
            };

             
            var enrolledCourses = new List<EnrolledCourse>
            {
                //Enrolled courses in first semester
                DatabaseSeeder.EnrollCourseSeeder(1,"Engineering Calculus 1", "CEE101", 1, 1, 1),
                DatabaseSeeder.EnrollCourseSeeder(2,"PHYSICS 1 FOR ENGINEERS (CALCULUS BASED)", "CEE102/L", 1, 1, 2),
                DatabaseSeeder.EnrollCourseSeeder(3,"Statics of Rigid Bodies", "CEE108", 1, 1, 2),
                DatabaseSeeder.EnrollCourseSeeder(4,"Statics of Rigid Bodies", "CEE108", 1, 2, 2),
             

                //Enrolled courses in second semester
                DatabaseSeeder.EnrollCourseSeeder(5,"Engineering Calculus 2", "CEE103", 2, 1, 2),
                DatabaseSeeder.EnrollCourseSeeder(6,"Thermodyanmics 2", "CEE101", 2, 1, 1),
                 DatabaseSeeder.EnrollCourseSeeder(7,"Data Structure and Algorithms", "CPE221/L", 2, 1, 2),

                //Enrolled courses in summer
                DatabaseSeeder.EnrollCourseSeeder(8,"Differential Equation", "CEE104", 3, 1, 2),

                
            };

            var students = new List<Student>
            {
                DatabaseSeeder.StudentSeeder(1,"550200","Cedric Setimo","CedricSetimo.550200@umindanao.edu.ph",3,1,
                "273F528F-5330-411F-9C6B-01543D6249C3"),
                 DatabaseSeeder.StudentSeeder(2,"547343","Ellaine Musni","EllaineMusni.550200@umindanao.edu.ph",3,1,
                "D0B26692-E380-4374-985F-239B56D06C20"),
            };

            var faculty = new List<Faculty>()
            {
                DatabaseSeeder.FacultySeeder(1, "321033", "Rey Mateo", 1,"53D8F920-EBEC-4DF3-8C53-21F6D123F0D9"),
                DatabaseSeeder.FacultySeeder(2, "797132", "Jeanelle Labsan",2,"78B4AF2A-672F-43C5-B819-5F0B407B7187"),
            };



            builder.Entity<Users>().HasData(users);
            builder.Entity<Department>().HasData(departments);
            builder.Entity<Program>().HasData(program);
            builder.Entity<SchoolYear>().HasData(schoolYears);
            builder.Entity<EnrolledCourse>().HasData(enrolledCourses);
            builder.Entity<Student>().HasData(students);
            builder.Entity<Faculty>().HasData(faculty);
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

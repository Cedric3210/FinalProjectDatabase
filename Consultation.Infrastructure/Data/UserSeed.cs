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
        public static Users UserSeeder(string id, string umid, string userName, string email, string password, Domain.Enum.UserType userType)
        {
            var Users = new Users
            {
                Id = id,
                UserName = userName,
                Email = email,
                NormalizedUserName = userName.ToUpper(),
                NormalizedEmail = email.ToUpper(),
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<Users>().HashPassword(null, password),
                SecurityStamp = "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4",
                ConcurrencyStamp = "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b",
                UserType = userType,
                UMID = umid
            };
            return Users;
        }

        public static Department DepartmentSeeder(int departmentId, string departmentName, string description)
        {

            var Department = new Department
            {
                DepartmentID = departmentId,
                DepartmentName = departmentName,
                Description = description
            };

            return Department;
        }

        public static Program ProgramSeeder(int programId, string programName, string description, int departmentId)
        {
            var Program = new Program
            {
                ProgramID = programId,
                ProgramName = programName,
                Description = description,
                DepartmentID = departmentId
            };
            return Program;
        }

        public static SchoolYear schoolYearSeeder(int schoolYearId, string Year1,string Year2, Domain.Enum.Semester semester, Domain.Enum.SchoolYearStatus schoolYearStatus)
        {
            var SchoolYear = new SchoolYear
            {
                SchoolYearID = schoolYearId,
                SchoolYearStatus = schoolYearStatus,
                Semester = semester,
                Year1 = Year1,
                Year2 = Year2

            };
            return SchoolYear;
        }

        public static EnrolledCourse EnrollCourseSeeder(string courseName,string courseCode,int schoolYearID,int studentID,int facultyID)
        {
            var EnrolledCourse = new EnrolledCourse
            {
                CourseCode = courseCode,
                CourseName = courseName,
                StudentID = studentID,
                FacultyID = facultyID,
                SchoolYearID = schoolYearID
            };
            return EnrolledCourse;
        }

        //public static Student StudentSeeder(int id,string studentName,string StudentUMID,string email,int programID)
        //{
        //      var student = new Student
        //      {
        //          StudentName = studentName,
        //          StudentUMID = StudentUMID,
        //          Email = email,
        //          ProgramID = programID,
        //          StudentID = id
        //      };
        //   return student;
        // }
    }
}









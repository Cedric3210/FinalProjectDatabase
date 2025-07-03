using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        public string StudentUMID { get; set; }
        
        public string StudentName { get; set; }
        
        public string Email { get; set; }

        //student to program is one-to-one relationship
        
        [ForeignKey(nameof(ProgramID))]
        public int ProgramID { get; set; }
        public virtual Program Program { get; set; }

        //student to ConsultationRequest is Many-to-Many relationship
        public List<ConsultationRequest> ConsultationRequests { get; set; }

        //The student should have one school year,

        //Student to SchoolYear is Many-to-One relationship

        public SchoolYear SchoolYear { get; set; }

        public Users Users { get; set; }

        public List<EnrolledCourse> EnrolledCourses { get; set; }
    }
}

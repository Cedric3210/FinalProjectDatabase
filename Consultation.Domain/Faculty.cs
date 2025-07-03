using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

        public string FacultyUMID { get; set; }
  
        public string FacultyName { get; set; }

        public Users Users { get; set; }
 
        //This need to be one-to-many
        public List<EnrolledCourse> EnrolledCourses { get; set; }
        
        public List<FacultySchedule> FacultySchedules { get; set; }

        //change to ICollection<>
        public List<ConsultationRequest> ConsultationRequests { get; set; }
     
        //Faculty should have one school year
        public SchoolYear SchoolYear { get; set; }


    }
}

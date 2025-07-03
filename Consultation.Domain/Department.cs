using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public string Description { get; set; }


        //The relationship between Department and Program is many-to-one, 

        //many programs to one department
        //public ICollection<Program> Programs { get; set; }
    }
}

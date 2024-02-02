using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.BLL.Models
{
    public enum Grade
    {
        A, B, C, D, E
    }

    [Table("Enrollment", Schema = "dbo")]
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Grade Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class TeacherEnrollment
    {
        public int TeacherEnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
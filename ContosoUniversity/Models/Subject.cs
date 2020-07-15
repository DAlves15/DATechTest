using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }

        [DisplayName("Courser")]
        public int CourseID { get; set; }

        [DisplayName("Teacher Name")]
        public int TeacherID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
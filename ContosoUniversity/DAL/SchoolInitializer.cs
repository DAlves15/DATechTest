using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1212,EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1213,EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1214,EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1215,EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1216,EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1217,EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1218,EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",Birthday=DateTime.Parse("1993-09-01"),RegistrationNumber=1219,EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
            new Teacher{FirstName="Preston",LastName="Teodosio",Birthday=DateTime.Parse("1993-09-01"),Salary=5000},
            new Teacher{FirstName="Ludovino",LastName="Silva",Birthday=DateTime.Parse("1993-09-01"),Salary=5500},
            new Teacher{FirstName="Charles",LastName="Alves",Birthday=DateTime.Parse("1993-09-01"),Salary=4000},
            new Teacher{FirstName="Gyanis",LastName="Ernesto",Birthday=DateTime.Parse("1993-09-01"),Salary=3607},
            new Teacher{FirstName="Loyd",LastName="Lo",Birthday=DateTime.Parse("1993-09-01"),Salary=3412},
            new Teacher{FirstName="Hernandez",LastName="Bin",Birthday=DateTime.Parse("1993-09-01"),Salary=4214},
            new Teacher{FirstName="Fernando",LastName="Elton",Birthday=DateTime.Parse("1993-09-01"),Salary=5346},
            new Teacher{FirstName="Lebron",LastName="Vieto",Birthday=DateTime.Parse("1993-09-01"),Salary=4221}
            };
            teachers.ForEach(s => context.Teachers.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry"},
            new Course{CourseID=4022,Title="Math"},
            new Course{CourseID=4041,Title="Engineering"},
            new Course{CourseID=1045,Title="Management"},
            new Course{CourseID=3141,Title="Art"},
            new Course{CourseID=2021,Title="Music"},
            new Course{CourseID=2042,Title="Literature"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
            new Subject{SubjectID=1010,CourseID=1050,Title="Atom I",Credits=3,TeacherID=1},
            new Subject{SubjectID=2020,CourseID=1050,Title="Atom II",Credits=3,TeacherID=1},
            new Subject{SubjectID=3030,CourseID=1050,Title="Periodic Table",Credits=3,TeacherID=1},
            new Subject{SubjectID=4040,CourseID=4022,Title="Primitives",Credits=3,TeacherID=2},
            new Subject{SubjectID=5050,CourseID=4022,Title="Derivatives",Credits=3,TeacherID=2},
            new Subject{SubjectID=6060,CourseID=4041,Title="Computer Engineering",Credits=3,TeacherID=3},
            new Subject{SubjectID=7070,CourseID=1045,Title="Entrepreneurship",Credits=4,TeacherID=4},
            new Subject{SubjectID=8080,CourseID=3141,Title="Frida Khalo I",Credits=4,TeacherID=5},
            new Subject{SubjectID=9090,CourseID=2021,Title="Composition",Credits=3,TeacherID=6},
            new Subject{SubjectID=1020,CourseID=2042,Title="Cervantes",Credits=4,TeacherID=7},
            new Subject{SubjectID=1120,CourseID=2042,Title="Shakespeare",Credits=4,TeacherID=8}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,SubjectID=1010,Grade=Grade.A},
            new Enrollment{StudentID=1,SubjectID=2020,Grade=Grade.C},
            new Enrollment{StudentID=1,SubjectID=3030,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=3030,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=4040,Grade=Grade.F},
            new Enrollment{StudentID=2,SubjectID=5050,Grade=Grade.F},
            new Enrollment{StudentID=3,SubjectID=1010},
            new Enrollment{StudentID=4,SubjectID=6060},
            new Enrollment{StudentID=4,SubjectID=7070,Grade=Grade.F},
            new Enrollment{StudentID=5,SubjectID=2020,Grade=Grade.C},
            new Enrollment{StudentID=6,SubjectID=3030},
            new Enrollment{StudentID=7,SubjectID=4040,Grade=Grade.A},
            new Enrollment{StudentID=7,SubjectID=1020,Grade=Grade.D},
            new Enrollment{StudentID=7,SubjectID=1120,Grade=Grade.C},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var teacherenrollments = new List<TeacherEnrollment>
            {
            new TeacherEnrollment{TeacherID=1,CourseID=1050},
            new TeacherEnrollment{TeacherID=1,CourseID=4022},
            new TeacherEnrollment{TeacherID=1,CourseID=4041},
            new TeacherEnrollment{TeacherID=2,CourseID=1045},
            new TeacherEnrollment{TeacherID=2,CourseID=3141},
            new TeacherEnrollment{TeacherID=2,CourseID=2021},
            new TeacherEnrollment{TeacherID=3,CourseID=1050},
            new TeacherEnrollment{TeacherID=4,CourseID=1050},
            new TeacherEnrollment{TeacherID=4,CourseID=4022},
            new TeacherEnrollment{TeacherID=5,CourseID=4041},
            new TeacherEnrollment{TeacherID=6,CourseID=1045},
            new TeacherEnrollment{TeacherID=7,CourseID=3141},
            };
            teacherenrollments.ForEach(s => context.TeacherEnrollments.Add(s));
            context.SaveChanges();
        }
    }
}
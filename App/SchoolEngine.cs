using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entidades;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {
            
        }

        public void Initialize()
        {
            School = new School("Platzi Academy", 2012, SchoolType.elementary,
                        city: "Bogotá", country: "Colombia"
                        );

            LoadCourses();
            LoadSubjects();
            // LoadAssessments();
        }

        private void LoadSubjects()
        {
            foreach (var course in School.Courses)
            {
                var SubjectList = new List<Subject>(){
                                new Subject{Name = "Maths"},
                                new Subject{Name = "PE"},
                                new Subject{Name = "Spanish"},
                                new Subject{Name = "Biology"}
                };
                course.Subjects = SubjectList;
            }
        }

        private void LoadAssessments()
        {

            foreach (var course in School.Courses)
            {
                foreach (var subject in course.Subjects)
                {
                    foreach (var student in course.Students)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var assessm = new Assessment
                            {
                                Subject = subject,
                                Name = $"{subject.Name} Assessm#{i + 1}",
                                Grade = (float)(5 * rnd.NextDouble()),
                                Student = student
                            };
                            student.Assessments.Add(assessm);
                        }
                    }
                }
            }

        }

        private List<Student> GenerateRandomStudents(int amount)
        {
            string[] firstName = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] middleName = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

            var StudentList = from fn in firstName
                            from mn in middleName
                            from ln in lastName
                            select new Student{ Name = $"{fn} {mn} {ln}"};

            return StudentList.OrderBy( (st)=> st.UniqueId ).Take(amount).ToList();
        }

        private void LoadCourses()
        {
            School.Courses = new List<Course>(){
                new Course (){ Name = "101", Shift = ShiftType.Morning},
                new Course (){Name = "201", Shift = ShiftType.Morning},
                new Course{Name = "301", Shift = ShiftType.Morning},
                new Course{Name = "401", Shift = ShiftType.Morning},
                new Course{Name = "401", Shift = ShiftType.Afternoon},
                new Course{Name = "202", Shift = ShiftType.Evening},
                new Course{Name = "302", Shift = ShiftType.Evening},
                new Course{Name = "402", Shift = ShiftType.Evening}
            };

            Random rnd = new Random();
            foreach (var c in School.Courses)
            {
                int randomAmount = rnd.Next(5, 20);
                c.Students = GenerateRandomStudents(randomAmount);
            }
        }
    }

}
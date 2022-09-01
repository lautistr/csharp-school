using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entidades
{
    public class Course
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public ShiftType Shift {get; set;}
        public List<Subject> Subjects {get; set;}
        public List<Student> Students {get; set;}

        public Course() => UniqueId = Guid.NewGuid().ToString();
    }
}
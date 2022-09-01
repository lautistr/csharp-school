using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entidades
{
    public class Student
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public List<Assessment> Assessments {get; set;} = new List<Assessment>();
        public Student() => UniqueId = Guid.NewGuid().ToString();
    }
}
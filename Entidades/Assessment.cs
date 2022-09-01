using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entidades
{
    public class Assessment
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public Student Student { get; set; }
        public float Grade { get; set; }
        public Assessment() => UniqueId = Guid.NewGuid().ToString();
    }
}
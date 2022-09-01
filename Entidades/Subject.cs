using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entidades
{
    public class Subject
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Subject() => UniqueId = Guid.NewGuid().ToString();
    }
}
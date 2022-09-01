using System;
using System.Collections.Generic;

namespace CoreSchool.Entidades
{
    public class School
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string name;
        public string Name
        {
            get { return "Copy: " + name; }
            set { name = value.ToUpper(); }
        }
        public int FoundationYear {get; set; }

        public string Country { get; set; }
        public string City { get; set; } 

        public SchoolType SchoolType {get; set;}

        public List<Course> Courses {get; set;}

        public School(string name, 
                      int year, SchoolType type, 
                      string country = "", 
                      string city = "") : base()
        {
            (Name, FoundationYear) = (name, year);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {SchoolType},{System.Environment.NewLine}Country: {Country}, City: {City} ";
        }

    }
}
using System;
using System.Collections.Generic;
using CoreSchool;
using CoreSchool.Entidades;
using CoreSchool.Util;
using static System.Console;

namespace Stage1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new SchoolEngine();
            engine.Initialize();

            printSchoolCourses(engine.School);
            Printer.WriteLine(100);
        }

        private static bool Predicado2(Course obj)
        {
            return obj.Name.StartsWith('4') ;
        }

        private static bool Predicado(Course obj)
        {
            return obj.Shift == ShiftType.Evening ;
        }

        private static void printSchoolCourses(School school)
        {
            if (school?.Courses != null)
            {
                foreach (var course in school.Courses)
                {
                    WriteLine($"Name: {course.Name}, Subjects: {course.Subjects}");
                }
            }
        }

        // private static void PrintCourses(Course[] coursesArray)
        // {
        //     int counter = 0;
        //     while (counter < coursesArray.Length)
        //     {
        //         WriteLine($"Course: {coursesArray[counter].Name}, Id: {coursesArray[counter].UniqueId}");
        //         counter++;
        //     }
        // }
    }
}
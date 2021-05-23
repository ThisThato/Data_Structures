using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new Dictionary<int, Student>()
            {
                {11, new Student{FirstName = "Andy",LastName= "Bernad",ID= 211} },
                {12, new Student{FirstName = "Jim",LastName= "Halpert",ID= 212} },
                {13, new Student{FirstName = "Micheal",LastName= "Scott",ID= 213} }
            };

            foreach(var index in Enumerable.Range(11, 3))
            {
                Console.WriteLine($"Student {students[index].FirstName}");
            }

            foreach(var student in students)
            {
                Console.WriteLine(student.Value.LastName);
            }
        }
    }
}

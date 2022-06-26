using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookOO
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public Dictionary<string, int> grades = new Dictionary<string, int>();

        public Student(int id, string name /*, string subject, int grade*/)
        {
            this.id = id;
            this.name = name;
            this.grades = new Dictionary<string, int>(); // {{ subject, grade }};
            
            
        }
        public Student()
        {
            this.id = 0;
            this.name = "";
            this.grades = new Dictionary<string, int>();
        }
        public void ShowInfo()
        {
            Console.WriteLine("Student ID: " + this.id + "        Name: " + this.name + "       Average Grade: " + this.ShowAverage());
            Console.WriteLine("Current graded assignments: ");
            foreach(var kvp in this.grades)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
        public int ShowAverage()
        {
            int average = 0;
            foreach(var kvp in grades)
            {
                average = average + kvp.Value;
            }
            return average / grades.Count;
        }
        public string CompareAverage(Student second)
        {
          if(this.ShowAverage() > second.ShowAverage())
            {
                return name;
            } else
            {
                return second.name;
            } 
        }
        public void HighestGrade()
        {

            var maxValueKey = grades.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var maxValue = grades.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
            Console.WriteLine("The highest grade for " + this.name + " is: ");
            Console.WriteLine("Assignment: " + maxValueKey + " Grade: " + maxValue);


        }
        public void LowestGrade()
        {
            var minValueKey = grades.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            var minValue = grades.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
            Console.WriteLine("The highest grade for " + this.name + " is: ");
            Console.WriteLine("Assignment: " + minValueKey + " Grade: " + minValue);
        }

    }
}

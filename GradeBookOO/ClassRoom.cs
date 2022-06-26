using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookOO
{
    internal class ClassRoom
    {
        public string name { get; set; }
        public Dictionary<string, Student> students = new Dictionary<string, Student>();

        public ClassRoom(string name /*, Dictionary<string, Student> students*/)
        {
            this.name = name;
            //this.students = students;
        }
        public void ShowClass()
        {
            Console.WriteLine(name);
        }
    }
}

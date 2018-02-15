using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02._2018
{
    class Group
    {
        public Group(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }
        
        public string  Name { get; set; }
        public List<Student> students { get; set; }

        public void YeniTelebe(Student s)
        {
            this.students.Add(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02._2018
{
    class Student
    {
        public Student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name{ get; set; }
        public string surname { get; set; }

        public int age { get; set; }
    }
}

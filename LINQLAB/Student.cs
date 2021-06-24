using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLAB
{
   public class Student
    {
       public string Name { get; set; }

       public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

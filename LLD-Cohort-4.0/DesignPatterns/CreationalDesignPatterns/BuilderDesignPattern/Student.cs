using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern
{
    internal class Student
    {
        public string name { get; } // mandatory params.

        //optional ones
        public int age { get; private set; }
        public string address { get; private set; }

        /*        public Student(string name)
                {
                    this.name = name;
                }

                public void setAge(int age)
                {
                  this.age = age;
                }
                public void setAddress(string address)
                {
                    this.address = address;
                }*/

        private Student(StudentBuilder obj)
        {
            name = obj.Name;
            age = obj.Age;
            address = obj.Address;

        }

        public class StudentBuilder
        {
            public string Name { get; }
            public int Age { get; private set; }
            public string Address { get; private set; }
            public StudentBuilder(string name)
            {
                Name = name;
            }
            public StudentBuilder setAge(int age)
            {
                Age = age;
                return this;
            }
            public StudentBuilder setAddress(string address)
            {
                Address = address;
                return this;
            }

            public Student Build()
            {
                Student student = new Student(this);
                return student;
            }

        }


    }
}

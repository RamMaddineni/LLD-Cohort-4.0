using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BuilderDesignPattern.Student
{
    internal class Run
    {
        public static void Start()
        {
            // Relation between Student and StudentBuilder is composite relationship
            Console.WriteLine("---Start of Builder Design Pattern---");
            Student student = new Student.StudentBuilder("Ram").setAge(24).setAddress("India").Build();
            Console.WriteLine("Name : " + student.name);
            Console.WriteLine("Age : " + student.age);
            Console.WriteLine("Address : " + student.address);
            Console.WriteLine("--End of Builder Design Pattern---");

/*            Console.WriteLine("--No need for Builder pattern--");
            Student student2 = new Student("Ram");
            student2.setAge(24);
            student2.setAddress("India");

            Console.WriteLine("Name : " + student2.name);
            Console.WriteLine("Age : " + student2.age);
            Console.WriteLine("Address : " + student2.address);
            Console.WriteLine("--end--");*/

            //Notes :
            //first object created using builder pattern is immutuable later.
            // the student2 is not immutable, becuase anyone can call setAge(),setAddress() properties.
            // So builder pattern is needed for immuatability.
            //and with build() method we can add any type of validations at Build() function itself, instead of adding validation at setters method.

            // so, i will follow builder pattern if there is need of immutability. else its an overkill.
        }

    }
}

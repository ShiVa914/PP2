using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student

{

    class Student

    {

        public string name;

        public int age;

        public double gpa;


        public Student()

        {

            name = "Valeriy";

            age = 19;

            gpa = 4;

        }

         public Student(string n, int a, double g)

        {

            name = n;

            age = a;

            gpa = g;
            
        }

        public Student(string n, int a)
        {
            name = n;
            age = a;
        }
        




        public override string ToString()

        {

            return name + " " + age + " " + gpa;

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Student b = new Student("Valera", 19);

            Console.WriteLine(b);

            Console.ReadKey();

        }

    }

}
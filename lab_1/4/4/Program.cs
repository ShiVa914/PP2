using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle

{

    public class Circle

    {

        public double Radius, Area, Length;

        public Circle()

        {

            Radius = 0;

            Area = 0;

            Length = 0;

        }

        public double FindArea()

        {

            return Math.PI * Radius * Radius;

        }

        public double FindLength()

        {

            return Math.PI * Radius * 2;

        }

        public Circle(double r)

        {

            Radius = r;

            Area = FindArea();

            Length = FindLength();

        }

        public override string ToString()

        {

            return Radius + " " + Area + " " + Length;

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            Circle C = new Circle(3);

            Console.WriteLine(C);

            
                Console.ReadKey();
            
        }

    }

}

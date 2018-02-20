using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime

{

    class Program

    {

        public static bool isprime(int a)

        {

            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
                if (a % i == 0) return false;
            return true;


        }

        static void Main(string[] args)

        {

            string a = Console.ReadLine();

            string[] arr = a.Split(' ');



            for (int i = 0; i < arr.Length; i++)

            {

                if (int.Parse(arr[i]) == 2 || int.Parse(arr[i]) == 3)

                {

                    Console.WriteLine(int.Parse(arr[i]));

                    continue;

                }

                if (isprime(int.Parse(arr[i])))

                    Console.WriteLine(arr[i], " ");

            }

            Console.ReadKey();

        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace max_min
{
    class MainClass
    { 
        public static void Main(string[] args)
        {
            StreamReader SR = new StreamReader(@"/Users/Валерий/Desktop/programming/input.txt");
            string s = SR.ReadLine();
            string[] x = s.Split(' ');
            int max = int.Parse(x[0]);
            int min = int.Parse(x[0]);
            for (int i = 1; i < x.Length; i++)
            {
                if (max < int.Parse(x[i]))
                    max = int.Parse(x[i]);
                if (min > int.Parse(x[i]))
                    min = int.Parse(x[i]);
            }
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.ReadKey();
        }
    }
}
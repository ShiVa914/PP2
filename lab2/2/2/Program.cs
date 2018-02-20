using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            List<int> prime = new List<int>();
            StreamReader SR = new StreamReader(@"/Users/Валерий/Desktop/programming/input.txt");
            string s = SR.ReadLine();
            string[] x = s.Split(' ');
            int[] n = new int[x.Length];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(x[i]);
                bool ok = true;
                for (int j = 2; j <= Math.Sqrt(n[i]); j++)
                {
                    if (n[i] % j == 0) ok = false;
                }
                if (ok && n[i] != 1)
                {
                    prime.Add(n[i]);
                    count = count + 1;
                }

            }
            int min = prime[0];
            for (int i = 0; i < prime.Count; i++)
            {
                if (prime[i] < min)
                    min = prime[i];
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}

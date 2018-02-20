
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace serializetoXML
{
    [Serializable]
    public class Complex
    {
        public int a;
        public int b;
        public Complex()
        {

        }
        public Complex(int a1, int b1)
        {
            a = a1;
            b = b1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(5, 9);
            Console.WriteLine("object created");
            XmlSerializer formatter = new XmlSerializer(typeof(Complex));
            using (FileStream fs = new FileStream("complex.xml", FileMode.Create))
            {
                formatter.Serialize(fs, complex);
                Console.WriteLine("object serialized");
            }
            //deserialization
            using (FileStream fs = new FileStream("complex.xml", FileMode.Open))
            {
                Complex newComplex = (Complex)formatter.Deserialize(fs);
                Console.WriteLine("object deserialized");
                Console.WriteLine("b - {5} : b1 - {9}");
                Console.ReadKey();
            }
        }
    }
}
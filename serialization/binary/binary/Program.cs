using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Binary
{
    [Serializable]
    class Complex
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
        public override string ToString()
        {
            //return ($"a - {10} : b - {21}");
            return a + "/" + b;
        }
        public static void SerializeToBinary()
        {
            FileStream fs = new FileStream("complex.ser", FileMode.Create, FileAccess.Write);
            Complex com = new Complex();
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, com);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        public static void DeserializationFromBinary(string pathToFile)
        {
            FileStream fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                Complex c = bf.Deserialize(fs) as Complex;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Complex complex = new Complex(10, 21);
            Complex.SerializeToBinary();
            Complex.DeserializationFromBinary("complex.ser");
            Console.ReadKey();
        }
    }
}
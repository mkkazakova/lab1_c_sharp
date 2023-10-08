

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Lessons
{

    class Program
    {

        static void Main(string[] args)
        {
            string msg = "Type {0,8} \t|  Size = {2,2}   |\t MIN = {3,30}\t|  MAX = {4}";

            Console.Title = "Data types C#";

            Console.WriteLine("\n\t\t\t\tINTEGER TYPES: \n");
            Console.WriteLine(string.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(msg, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(msg, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(msg, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(msg, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(msg, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(msg, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(msg, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));



            Console.WriteLine("\n\t\t\t\tFLOAT TYPES: \n");
            Console.WriteLine(string.Format(msg, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(string.Format(msg, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(string.Format(msg, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));



            Console.WriteLine("\n\t\t\t\tSYMBOL TYPES: \n");
            Console.WriteLine(string.Format(msg, "Char", typeof(Char).Name, sizeof(Char), (int)char.MinValue, (int)char.MaxValue));
            string str = "";
            Console.WriteLine(string.Format(msg, "string", typeof(string).Name, "-", Encoding.Default.GetByteCount(str) * 8, "зависит от расмера str"));
            // Размер переменных типа string зависит от того, сколько символов в записанной в них строке.
            // Размер каждого символа равен 2 байтам.


            Console.WriteLine("\n\t\t\t\tLOGIC TYP: \n");
            Console.WriteLine(string.Format(msg, "bool", typeof(bool).Name, sizeof(bool), bool.FalseString, bool.TrueString));




            Console.WriteLine("\n\t\t\t\tSPECIAL TYPES: \n");
            //Console.WriteLine(string.Format(msg, "object", typeof(Object).Name, "-", "-", "-"));
            Console.WriteLine(string.Format("Type {0,8} \t|  Значения определяются во время выполнения программы, когда создаются объекты конкретных типов данных", "object"));
            // Не имеет минимального и максимального значения,
            // т.к. это ссылочный тип данных, который может хранить ссылку на любой другой тип данных.
            // Значения для типа object определяются во время выполнения программы, когда создаются объекты конкретных типов данных
            //Console.WriteLine(string.Format(msg, "dynamic", "N/A", "N/A", "N/A", "N/A"));
            Console.WriteLine(string.Format("Type {0,8} \t|  Значения определяются во время выполнения программы, когда создаются объекты конкретных типов данных", "dynamic"));

            // Console.ReadKey();

        }
    }
}
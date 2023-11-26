using System;
using System.Text;
using System.IO;
namespace TestApplicationForStudy
{
    class Program
    {
        static int sum()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }
        static void Main(string[] args)
        {
            {
                BinaryWriter bWriter = new BinaryWriter(new FileStream("D:\\бинарный ввод-вывод.dat", FileMode.OpenOrCreate));
                int a = sum();
                bWriter.Write(a);
                bWriter.Close();
            }
            Console.WriteLine("*************");
            {
                int i;
                double d;
                string str;
                BinaryReader bReader = new BinaryReader(new FileStream("D:\\бинарный ввод-вывод.dat", FileMode.Open));
                i = bReader.ReadInt32();
                d = bReader.ReadDouble();
                str = bReader.ReadString();
                Console.WriteLine("Читаем i = " + i);
                Console.WriteLine("Читаем d = " + d);
                Console.WriteLine("Читаем str = " + str);
                bReader.Close();
            }
            Console.ReadLine();
        }
    }
}

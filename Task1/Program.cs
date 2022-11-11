using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {

        //Выберите любую папку на своем компьютере, имеющую вложенные директории.
        //Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        static void Main(string[] args)
        {
            string path = @"C:\Temp";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);
            Console.ReadLine();
        }
    }
}

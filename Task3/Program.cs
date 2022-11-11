using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    internal class Program
    {
        //Вручную подготовьте текстовый файл с фрагментом текста.
        //Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.

        static void Main(string[] args)
        {
            string path = @"C:\Temp\Slovenia.txt";
            int charCount = 0;
            int wordCount = 0;
            int lineCount = 1;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    charCount++;

                    if (sr.Read() == ' ')
                    {
                        wordCount++;
                    }

                    if (sr.Read() == '\n')
                    {
                        lineCount++;
                    }
                }
                Console.WriteLine("{0}, {1}, {2}.", charCount, wordCount, lineCount);
                Console.ReadLine();
            }
        }
    }
}



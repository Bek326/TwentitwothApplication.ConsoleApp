using System;
using System.IO;
using System.Linq;

namespace TwentitwothApplication.ConsoleApp
{
    class Program
    {
        public static void Folder()
        {

            DirectoryInfo dirName = new DirectoryInfo(@"C:\Users\TheDarkKnight\Downloads\TestFolder");
            if (dirName.Exists)
            {
                long sum = 0;
                var dirs = dirName.GetDirectories().ToList();
                dirs.Add(dirName);
                foreach (var dir in dirs)
                {
                    var files = dir.GetFiles();
                    foreach (var file in files)
                    {
                        sum += file.Length;
                    }
                }
                Console.WriteLine($"Объем:{sum}");
            }

        }
        static void Main(string[] args)
        {

            Folder();
            Console.ReadKey();
        }
    }
}

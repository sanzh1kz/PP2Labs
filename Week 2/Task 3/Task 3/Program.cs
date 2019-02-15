using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void Spaces(int level)
        {
            for (int i = 0; i < level; i++)                          
                Console.Write("     ");
        }

        public static void Files(DirectoryInfo d, int num)               //метод, который открывает файлы
        {
            foreach(FileInfo f in d.GetFiles())                          //показывает файлы из директории 
            {
                Spaces(num);
                Console.WriteLine(f.Name);                               //выводит имена папок
            }

            foreach(DirectoryInfo dir in d.GetDirectories())             //показывает каталог из директории
            {
                Spaces(num);
                Console.WriteLine(dir.Name);
                Files(dir, num + 1);                                     //рекурсивно вызывает этот метод снова, чтобы показать другие файлы
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo(@"C:\Users\sanzh\Desktop\pp");  //создал директорию
            Files(path, 0);                                                        //передал парметры в метод
            Console.ReadKey();
        }
    }
}

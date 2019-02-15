using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        public static void Adding()
        {
            string original = @"C:\Users\sanzh\Desktop\pp\c#\PP2\Week 2\Task 4\Task 4\path";        //начальная оригинальная папка
            string FileName = Console.ReadLine();                                                   //вводим имя через консоль

            original = Path.Combine(original, FileName);                                            //создал файл в оригинальной папке

            File.WriteAllText(original, "something");                                               //что-то записал в этот файл, в данном случае "что-то"

            string copy = @"C:\Users\sanzh\Desktop\pp\c#\PP2\Week 2\Task 4\Task 4\path1";           //папка, в которую мы скопируем файл
            string copyfile = Path.Combine(copy, FileName);                                         //создаем файл во второй папке 

            File.Copy(original, copyfile, true);                                                    //копируем файл из первой оригинальной папки во вторую

            Deleting(original);                                                                     //запускаем метод удаления
        }

        public static void Deleting(string path)  
        {
            if (File.Exists(path))                                                                   //если такая папка существует 
                File.Delete(path);                                                                   //то мы удаляем ее
        }

        static void Main(string[] args)
        {
            Adding();                         //начало кода тут, сразу начинаем с метода "добавления"
        }
    }
}

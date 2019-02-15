using System;
using System.IO;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Explorer FileManager = new Explorer();                        //создал новый FileManager
            FileManager.Start(@"C:\Users\sanzh\Desktop");                 //передаем путь в метод старт
        }
    }

    class Explorer                                                        //создал новый класс
    {
        public int cursor;
        public int size;

        public Explorer()
        {
            cursor = 0;
        }

        public void Color(FileSystemInfo file, int index)
        {
            if (index == cursor)
                Console.BackgroundColor = ConsoleColor.Red;
            else if (file.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);           //передаем путь в созданную директорию
            FileSystemInfo[] files = directory.GetFileSystemInfos();     //берет информацию с директории и превращает в массив файлов и каталогов в переменной files
            size = files.Length;                                         //для облегчения создали size и "запихали" размер, чтобы не выйти из рамки отладки
            int index = 0;
            foreach (FileSystemInfo ff in files)                         //пробегаемся по всем элементам...
            {
                Color(ff, index);                                        //...одновременно запуская метод "цвета"...
                Console.WriteLine(ff.Name);                              //...и выписывая все файлы
                index++;
            }
        }

        public void Start(string path)
        {
            ConsoleKeyInfo button = Console.ReadKey();                    //создаем кнопку (типа курсора)
            FileSystemInfo ff = null;
            while (button.Key != ConsoleKey.E)                            //цикл уайл означает, что пока не будет нажата "Е" цилк не прекратится 
            {
                Console.BackgroundColor = ConsoleColor.Black;             //задаем черный цвет фону
                Console.Clear();                                          //очищаем отладку
                Show(path);                                               //переходим к методу "показа"
                button = Console.ReadKey();                               
                
                if(button.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0)
                        cursor = size - 1;
                }

                else if(button.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == size)
                        cursor = 0;
                }
            }
        }
    }

    
}

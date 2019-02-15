using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../input.txt");    //открыл поток
            string str = sr.ReadToEnd();                                 //вычитал с файла и ввел в строку 

            int n = str.Length;                                          //записал размер строки в интереджер чтобы было намного легче 

            for(int i = 0; i < n / 2; i++)                               //пробежался до половины строки                         
            {
                if (str[i] != str[n - i - 1])                            //если первая половина не равна ко второй,...
                {
                    Console.WriteLine("No");                             //то выводим "нет"
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Yes");                                    //в противном случае выводим "да"
            Console.ReadKey();
            sr.Close();                                                  //закрываем поток 
        }
    }
}

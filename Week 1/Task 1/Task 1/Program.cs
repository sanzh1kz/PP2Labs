using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            List<int> Prime = new List<int>(); //создал список, чтобы посчитать элементы 

            string[] st = Console.ReadLine().Split(); //записывал элементы пропуская пробелы 

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(st[i]);  // ввел в массив строку 
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]) == 1) // передал числа в метод
                {
                    Prime.Add(arr[i]); // если с метода вернется 1, то записываем число в лист
                }
            }

            Console.WriteLine(Prime.Count); // вывожу количество чичел в листе

            for(int i = 0; i < Prime.Count; i++)
            {
                Console.Write(Prime[i] + " "); // вывожу каждый элемент через пробел
            }

            Console.ReadKey();

        }

        public static int isPrime(int a)
        {
            for (int i = 2; i <= a; i++)
            {
                if ((i == a) || (i > Math.Sqrt(a)))
                {
                    return 1;
                }

                if (a % i == 0 && i != a || a == 1)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}

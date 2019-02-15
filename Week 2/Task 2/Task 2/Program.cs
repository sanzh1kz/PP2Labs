using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../input.txt");     //открыл поток
            string s = sr.ReadToEnd();                                    //прочел его полностью
            String[] str = s.Split();                                     
            sr.Close();                                                   //закрыл поток

            List<int> arr = new List<int>();        
            List<int> prime = new List<int>();                            //создал два листа чтобы легче было посчитать количество элементов

            foreach(string a in str)
            {
                arr.Add(int.Parse(a)); 
            }

            for (int i = 0; i < arr.Count(); i++)
            {
                if (IsPrime(arr[i]) == 1)                                //передал числа из массива в метод, и если вернет тру, то добавляю в лист праймов
                    prime.Add(arr[i]);
            }

            StreamWriter sw = new StreamWriter("../../../output.txt");   //открыл поток для аутпута
            if (prime.Count >= 1)                                        //если он не пустой, то вывожу все элементы
            {
                for (int i = 0; i < prime.Count; i++)                    
                {
                    sw.Write(prime[i] + " ");
                }

            }
            else sw.Write("No primes in the array");                     //в противном случае выходит запись, что он пуст
            sw.Close();                                                  //закрываю поток 
        }

        public static int IsPrime(int num)                               //проверка на прайм, который мы делаем не впервые
        {
            for (int i = 2; i <= num; i++)
            {
                if ((i == num) || (i > Math.Sqrt(num)))
                {
                    return 1;
                }

                if(num % i == 0 && i != num || num == 1)
                {
                    return 0;
                }
            }

            return 0;
        }
    }
}

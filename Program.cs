using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Random random = new Random();

            Console.WriteLine("Лист: ");
            int average = 0;
            for (int i = 0; i < 15; i++)
            {
                list.Add(random.Next(-20, 20));
                average += (int)list[i];
                Console.Write(list[i] + " ");
            }

            average /= list.Count;
            Console.WriteLine("\n\nСреднее арифметическое:\n" + average);

            Console.WriteLine("\nЭлементы которые больше среднего арифметического: ");
            foreach (int item in list)
            {
                if (item > average)
                {
                    Console.Write(item + " ");
                }
            }

            Console.ReadLine();

        }
    }
}


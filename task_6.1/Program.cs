using System;

namespace task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите предложение без знаков препинания: ");
                string input = Console.ReadLine();
                string[] arr = input.Split(' ');
                int maxLength = 0;
                int index = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length > maxLength)
                    {
                        maxLength = arr[i].Length;
                        index = i;
                    }
                }
                Console.WriteLine("Самое длинное слово(слова): ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length == arr[index].Length)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }
}
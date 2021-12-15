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
                string input = Console.ReadLine();  //считываем строку
                string[] arr = input.Split(' ');    //разделяем строку на массив слов, разделитель пробел
                int maxLength = 0;  //максимальная длина слова
                string longest = "";    //самое длинное слово
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length > maxLength)  //сравниваем длину слова каждого элемента массива и присваиваем значения
                    {
                        maxLength = arr[i].Length;
                        longest = arr[i];
                    }
                }
                Console.WriteLine("Самое длинное слово: \"{0}\". Число букв: {1}", longest, maxLength);
            }
        }
    }
}
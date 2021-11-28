using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string inpuntLine = Console.ReadLine();  // Вводим строку
            string[] stringLine = inpuntLine.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);  /// Split - разбили масив отдельных слов , ///Char - позволяет обращаться к эл-там строки как к эл-там массива
                                                                                                                  ///StringSplitOptions-перечисление используется для включения или исключения подстрок, созданных String.Split методом
                                                                                                                  ///RemoveEmptyEntries-Исключить элементы массива, содержащие пустые строки, из результата.
            int index = 0, counter=0, maxWord = 0;

            for (int i = 0; i < stringLine.Length; i++)  ////Length -  длина строки
            {
                if (stringLine[i].Length > maxWord)
                {
                    maxWord = stringLine[i].Length;
                    index = i;
                }
            }
            for (int i = 0; i < stringLine.Length; i++)
            {
                if (stringLine[i] == stringLine[index]) counter++;
            }

                Console.Write("Самое длинное слово в строке: {0}. Встретилось раз: {1}", stringLine[index], counter);
            Console.ReadLine();
        }
    }
}
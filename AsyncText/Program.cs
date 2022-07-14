using System;
using VowCon;

namespace AsyncText
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите текст или слово: ");
            var Counter = new VowConChars(Console.ReadLine());            
            try
            {
                Console.WriteLine($"Гласных букв: {Counter.AsyncCountVowel().Result}");
                Console.WriteLine($"Согласных букв: {Counter.AsyncCountConsonant().Result}");
                Console.WriteLine($"Количество твёрдых знаков: {Counter.FirmSign().Result}");
                Console.WriteLine($"Количество мягких знаков: {Counter.SoftSign().Result}");
                Console.WriteLine($"Количество иных знаков: {Counter.Text.Length - Counter.AsyncCountVowel().Result - Counter.AsyncCountConsonant().Result - Counter.FirmSign().Result - Counter.SoftSign().Result}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
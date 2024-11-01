using System;
using System.Collections.Generic;

namespace Homework_01_Random
{
    internal class MagicBall
    {
        static void Main()
        {
            string[] answers = { "Да, конечно!", "Нет, точно нет.", "Возможно...", "Попробуй позже.", "Это тайна." };
            Random random = new Random();

            Console.WriteLine("Добро пожаловать в волшебный шар предсказаний!");
            Console.Write("Задайте свой вопрос: ");
            string question = Console.ReadLine();

            string response = answers[random.Next(answers.Length)];
            Console.WriteLine($"Ответ: {response}");
        }
    }
}

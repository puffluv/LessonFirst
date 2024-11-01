using System;

namespace Lesson1
{
    class ConsolePrac
    {
        static void Main()
        {
            // Просим пользователя ввести имя
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            // Просим пользователя ввести возраст
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Вычисляем, сколько лет осталось до следующего десятка
            int yearsUntilNextDecade = 10 - (age % 10);

            // Выводим приветственное сообщение
            Console.WriteLine($"Привет, {name}! Вам {age} лет.");

            // Сообщаем, сколько лет осталось до следующего десятка
            Console.WriteLine($"До следующего десятка вам осталось {yearsUntilNextDecade} лет.");
        }
    }
}

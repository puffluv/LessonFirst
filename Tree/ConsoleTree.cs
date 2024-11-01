using System;

namespace Tree
{
    internal class ConsoleTree
    {
        static void Main()
        {
            Console.Write("Введите высоту ёлки: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                // Рисуем пробелы для центрирования звёзд
                Console.Write(new string(' ', height - i));

                // Рисуем звёзды
                Console.WriteLine(new string('*', i * 2 - 1));
            }

            // Рисуем ствол ёлки
            Console.Write(new string(' ', height - 1));
            Console.WriteLine("|");
        }
    }
}

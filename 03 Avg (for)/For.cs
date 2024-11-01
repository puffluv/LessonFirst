using System;

namespace _03_Avg__for_
{
    internal class For
    {
        static void Main()
        {
            // Запрашиваем у пользователя количество оценок
            Console.Write("Введите количество оценок: ");
            int count = int.Parse(Console.ReadLine());

            // Переменная для хранения суммы всех оценок
            int sum = 0;

            // Запрашиваем оценки и суммируем их
            for (int i = 1; i <= count; ++i)
            {
                Console.Write($"Введите оценку {i}: ");
                int grade = int.Parse(Console.ReadLine());
                sum += grade;  // Добавляем оценку к общей сумме
            }

            // Вычисляем среднее арифметическое
            double average = (double)sum / count;

            // Выводим результат
            Console.WriteLine($"Среднее арифметическое введенных оценок: {average}");

        }
    }
}

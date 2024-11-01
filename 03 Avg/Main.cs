using System;

namespace _03_Avg
{
    internal class Program
    {
        static void Main()
        {
            // Просим пользователя ввести три оценки
            Console.Write("Введите первую оценку: ");
            int grade1 = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую оценку: ");
            int grade2 = int.Parse(Console.ReadLine());

            Console.Write("Введите третью оценку: ");
            int grade3 = int.Parse(Console.ReadLine());

            // Подсчитываем сумму и среднее арифметическое
            int sum = grade1 + grade2 + grade3;
            double average = (double)sum / 3;

            // Выводим результат
            Console.WriteLine($"Среднее арифметическое введенных оценок: {average}");
        }
    }
}

using System;

namespace _05_if_else
{
    internal class Score
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("Отлично!");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Хорошо");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else
            {
                Console.WriteLine("Неудовлетворительно");
            }
        }
    }
}

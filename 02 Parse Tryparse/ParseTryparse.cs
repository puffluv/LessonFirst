using System;

namespace _02_Parse_Tryparse
{
    internal class ParseTryparse
    {
        static void Main()
        {
            string numStr = "42sad";
            int result;
            bool success = int.TryParse(numStr, out result);

            if (success)
            {
                Console.WriteLine("success " + result);
            }
            else
            {
                Console.WriteLine("Ошибка (Parse): unable to parse '{0}' to an integer.", numStr);
            }


            // parse

            string numStr2 = "42sad";

            try
            {
                int result2 = int.Parse(numStr2);
                Console.WriteLine("success2");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
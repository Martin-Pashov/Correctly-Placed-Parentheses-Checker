using System;

namespace Correctly_Placed_Parentheses_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text that includes parentheses: ");

            string input = Console.ReadLine();
            int count = 0;
            int lengthOfInput = input.Length;


            for (int i = 0; i < lengthOfInput; i++)
            {
                if (input[i] == '(')
                {
                    count++;
                }
                else if (input[i] == ')')
                {
                    count--;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Properly placed parentheses!");
            }
            else
            {
                Console.WriteLine("Improperly placed parentheses!");
            }
        }
    }
}

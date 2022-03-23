using System;

namespace SyntaxSugarExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";

            Console.WriteLine(response);

            
                //Inferred Typing
               //String Interpolation
               //and the Ternary Operator
        }
    }
}

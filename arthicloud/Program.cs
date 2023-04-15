using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
                 * 1. Get user input to exit loop.
                 * 2. When user enters the correct answer continue to random math question.
                 * 3. Start logging user points earned per question.
                 * 4. Give user an option between question from addition/subtraction/multi/div.
                 * 5. Test console application if features work. Move on to web version.
*/

namespace arthicloud
{

    internal class Program
    {
        static void Main(string[] args)
        {
            MainScreen();
            Question();
        }

        // This is the constant Main Screen.
        static string MainScreen()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("================== Arithmetic Cloud ===================");
            Console.WriteLine("==================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is your question.");
            Console.WriteLine();
            return Console.ReadLine();

        }

        //logic for question.
        static void Question()
        {
            var random = new Random(); // gets random number

            var symbols = new string[4] { "+", "-", "*", "/" }; // array stores arithmetic instructions
            var randomSymbols = random.Next(symbols.Length); // set random number, however max is the length of array
            var symbolValue = symbols[randomSymbols]; // uses randomSymbol int and returns string of the symbol.



            var num1 = random.Next(100); // random number 1
            var num2 = random.Next(100); // random number 2
            Console.WriteLine("What is, {0} {1} {2}", num1, symbolValue, num2); // tells users how to approach math question thought *,+,- or /
            var answer = Console.ReadLine(); // captures user input through read console command.
            int computerAnswer;
            var loopControl = true;

            while (loopControl)
            {
                switch (symbolValue)
                {
                    case "+":
                        computerAnswer = num1 + num2;
                        if (int.Parse(answer) == computerAnswer)
                        {
                            Console.WriteLine("You're Right!");
                        }
                        else
                        {
                            Console.WriteLine("You're Wrong!");
                            loopControl = false;
                        }

                        break;
                    case "-":
                        computerAnswer = num1 - num2;
                        if (int.Parse(answer) == computerAnswer)
                        {
                            Console.WriteLine("You're Right!");
                        }
                        else
                        {
                            Console.WriteLine("You're Wrong!");
                            loopControl = false;
                        }

                        break;

                    case "*":
                        computerAnswer = num1 * num2;
                        if (int.Parse(answer) == computerAnswer)
                        {
                            Console.WriteLine("You're Right!");
                        }
                        else
                        {
                            Console.WriteLine("You're Wrong!");
                            loopControl = false;
                        }
                        break;
                    case "/":
                        computerAnswer = num1 / num2;
                        if (int.Parse(answer) == computerAnswer)
                        {
                            Console.WriteLine("You're Right!");
                        }
                        else
                        {
                            Console.WriteLine("You're Wrong!");
                            loopControl = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Oooops something went wrong!");
                        break;
                }
            }
        }

        
    }
}

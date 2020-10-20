using System;

namespace Basic_Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            //Default value is "not-a-number"
            double result = double.NaN;

            //Switch statement for maths
            switch (op)
            {
                case "Add":
                    result = num1 + num2;
                    break;
                case "Subtract":
                    result = num1 - num2;
                    break;
                case "Multiply":
                    result = num1 * num2;
                    break;
                case "Divide":
                    //Asks for non-zero divisor
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "Modulus":
                    result = num1 % num2;
                    break;
                //Return text for incorrect option entry
                default:
                    break;
            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            //Title
            Console.WriteLine("Basic Calculator in C#\r");
            Console.WriteLine("Warning! Case-sensitive!\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                //Declare vars and set to empty
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //First input request
                Console.WriteLine("Type a number, the press Enter:");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not a valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                //Second input request
                Console.WriteLine("Type a another number, the press Enter:");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not a valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                //Choose operator
                Console.WriteLine("Operator?");
                Console.WriteLine("- Add");
                Console.WriteLine("- Subtract");
                Console.WriteLine("- Multiply");
                Console.WriteLine("- Divide");
                Console.WriteLine("- Modulus");
                Console.WriteLine("Input?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result {0:0.##}\n", result);
                }

                catch (Exception e)
                {
                    Console.WriteLine("An exception occured trying to do the maths.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                //Close program or continue
                Console.Write("Press 'E' and 'Enter' to close the program, or press 'Enter' to continue...");
                if (Console.ReadLine() == "e") endApp = true;

                //Linespacing
                Console.WriteLine("\n");
            }
            return;
        }
    }
}

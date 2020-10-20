using System;

namespace Tax_Calculator
{
	class Calculator
	{
		public static double DoOperation(double income, double tax_deduction)
		{
			//Default value is "not-a-number"
			double tax = double.NaN;

			//If statement for calculation
			if (income <= 18200)
			{
				tax = 0;
			}
			else if (income <= 37000)
			{
				tax = ((income - 18200) * 0.19) - tax_deduction;
			}
			else if (income <= 90000)
			{
				tax = ((income - 37000) * 0.325 + 3572) - tax_deduction;
			}
			else if (income <= 180000)
			{
				tax = ((income - 90000) * 0.37 + 20797) - tax_deduction;
			}
			else if (income >= 180000)
			{
				tax = ((income - 180000) * 0.45 + 54096) - tax_deduction;
			}

			return tax;
		}

	}


	class Program
	{
		static void Main()
		{
			bool endApp = false;

			//Title
			Console.WriteLine("Tax Calculator in C#\r");
			Console.WriteLine("--------------------\n");

			while (!endApp)
			{
				//First input request (income)
				Console.WriteLine("Enter yearly income:");
				string incomeInput = Console.ReadLine();

				double cleanNum1;
				while (!double.TryParse(incomeInput, out cleanNum1))
				{
					Console.Write("This is not a valid input. Please enter an integer value: ");
					incomeInput = Console.ReadLine();
				}

				//Second input request (tax deduction)
				Console.WriteLine("\nEnter tax deduction:");
				string deductionInput = Console.ReadLine();

				double cleanNum2;
				while (!double.TryParse(deductionInput, out cleanNum2))
				{
					Console.Write("This is not a valid input. Please enter an integer value: ");
					deductionInput = Console.ReadLine();
				}

				try
				{
					double tax = Calculator.DoOperation(cleanNum1, cleanNum2);
					if (double.IsNaN(tax))
					{
						Console.WriteLine("This operation will result in a mathematical error.\n");
					}
					else
					{
						double leftover = cleanNum1 - tax;
						Console.WriteLine(format: "\nTax: ${0:0.00}\n", tax);
						Console.WriteLine(format: "Leftover: ${0:0.00}\n", leftover);
					}
				}

				catch (Exception e)
				{
					Console.WriteLine("An exception occured trying to do the maths.\n - Details: " + e.Message);
				}

				//Close program or continue
				Console.Write("Press 'E' and 'Enter' to close the program, or press 'Enter' to continue...");
				if (Console.ReadLine() == "e")
				{
					endApp = true;
				}

				//Linespacing
				Console.WriteLine("\n");
			}
			return;
		}
	}
}

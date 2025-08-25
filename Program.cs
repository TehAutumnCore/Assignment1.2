using System;

namespace ConsoleApp1
{

    public class BooleanCheck
    {
        public void Check()
        {
            Console.Write("Enter first integer: ");
            if(!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            Console.WriteLine("Enter second integer: ");
            if(!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }

            if (num1 == num2)
                Console.WriteLine($"{num1} and {num2} are equal");
            else
                Console.WriteLine($"{num1} and {num2} are not equal");
        }
    }

    public class SumOfTenNaturalNumber
    {
        public string SumOneToTen()
        {
            int runningTotal = 0;
            for (int i = 1; i <= 10; i++)
            {
                runningTotal += i;
            }
            return $"The Sum is: {runningTotal}";
        }
    }


    /*
     Create a calculator application using a menu
        Prompt user to select an operation
        take user input and have it correspond to a case whether that is additional, substraction, multiplication, division
        perform math and return result (div by 0 exc for division)
     
     */
    public class Calculator
    {
        public decimal Menu()
        {
            Console.WriteLine(
            """
            Please select option from the menu
            1. Addition
            2. Subtraction
            3. Multiplication
            4. Division
            5. Exit
            """);
            
            while (true)
            {

                if(!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Please choose a valid option (1-5)");
                    continue;
                }

                switch (choice)
                {
                    case 1: //Addition
                        {
                            Console.WriteLine("Please enter the first number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal a)) {Console.WriteLine("Invalid number."); break;}

                            Console.WriteLine("Enter the second number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal b)) {Console.WriteLine("Invalid number."); break;}

                            decimal result = a + b;
                            Console.WriteLine($"The result is: {result}");
                            break;
                        }
                    case 2: //Subtraction
                        {
                            Console.WriteLine("Please enter the first number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal a)) {Console.WriteLine("Invalid number."); break;}



                            Console.WriteLine("Enter the second number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal b)) {Console.WriteLine("Invalid number.");break;}

                            decimal result = a - b;
                            Console.WriteLine($"The result is: {result}");
                            break;
                        }

                    case 3: //Multiplication
                        {
                            Console.WriteLine("Please enter the first number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal a)) {Console.WriteLine("Invalid number."); break;}


                            Console.WriteLine("Enter the second number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal b)) {Console.WriteLine("Invalid number."); break;}

                            decimal result = a * b;
                            Console.WriteLine($"The result is: {result}");
                            break;
                        }

                    case 4: //Division
                        {
                            Console.WriteLine("Please enter the first number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal a)) {Console.WriteLine("Invalid number."); break;}


                            Console.WriteLine("Enter the second number");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal b)) {Console.WriteLine("Invalid number."); break;}

                            if (b == 0) {Console.WriteLine("You can't divide by zero");break;}

                            decimal result = a / b;
                            Console.WriteLine($"The result is: {result}");
                            return result;

                        }
                    case 5: //exit
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BooleanCheck TrueOrFalse = new BooleanCheck();
            TrueOrFalse.Check();

            SumOfTenNaturalNumber Sum = new SumOfTenNaturalNumber();
            Sum.SumOneToTen();

            Calculator calculator = new Calculator();
            calculator.Menu();

            //Console.WriteLine("Hello, World!");
        }
    }
}

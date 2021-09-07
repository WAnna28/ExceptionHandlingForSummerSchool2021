using ExceptionLib;
using ExceptionRun.Enums;
using ExceptionRun.ExtensionMethods;
using ExceptionRun.Models;
using System;
using System.Collections.Generic;

namespace ExceptionHandlingForSummerSchool
{
    class Autumn
    {

    }

    class Program
    {
        // example 1
        public static List<string> Words;
        static void Main(string[] args)
        {
            // example 1
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Coffee");
            Words.Add("Dark Chocolate");

            //example 2
            crazyMathProblem();

            //example 3
            try
            {
                crazyMathProblem();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is: " + ex.Message);
                Console.WriteLine("Better luck next time!");
            }
            finally
            {
                Console.WriteLine("The block finally sends you Hi!");
            }

            //xample 4: throw
            try
            {
                Autumn autumn2020 = null;
                autumnMagic(autumn2020);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // example 5: Most specific/Least specific
            try
            {
                Autumn autumn2021 = null;
                autumnMagic(autumn2021);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            //example 6: custom exception
            int num1 = readNum("Type your first number :");
            int num2 = readNum("Type your second number :");
            Operation operation = readOperation();

            Calculator calc = new Calculator();
            try
            {
                if (num1 == 2020)
                    throw new CalculationException("Just for testing a custom exception!");
                   // throw new DivideByZeroException("JLK:LKHN:LKHN:LKNH!!!!!!!");

                int result = calc.Calculate(operation, num1, num2);
                Console.WriteLine();
                Console.WriteLine("Result of " + num1 + " " + operation + " " + num2 + " = " + result + ".");
            }
            catch (CalculationException ex)
            {
                Console.WriteLine("CalculationException's error message is: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is: " + ex.Message);
                Console.WriteLine("Better luck next time!");

                return;
            }
            //catch (Exception)
            //{
            //    Console.WriteLine("DEFAULT");
            //}
            finally
            {
                Console.WriteLine("The block finally sends you hi!");
            }

            Console.ReadLine();
        }

        // example 2
        private static int crazyMathProblem()
        {
            var income = 1000;
            for (int i = 10; i >= 0; i--)
            {
                income = income / i;
            }

            return income;
        }

        //example 4
        private static void autumnMagic(Autumn autumn)
        {
            if (autumn == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "autumn");
            }
        }

        //example 6
        static int readNum(string msg)
        {
            string stringNum;
            int num;
            do
            {
                Console.WriteLine(msg);
                stringNum = Console.ReadLine();
            } while (!int.TryParse(stringNum, out num));

            return num;
        }

        static Operation readOperation()
        {
            string stringOperation;
            Operation operation;
            do
            {
                Console.WriteLine("Enter the operation + (addition), - (subtraction), * (multiplication), / (division)");
                stringOperation = Console.ReadLine();

                operation = stringOperation.ToOperation();
            } while (operation == Operation.Unknown);

            return operation;
        }
    }
}
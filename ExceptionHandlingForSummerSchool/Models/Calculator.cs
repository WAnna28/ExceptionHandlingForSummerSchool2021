using ExceptionRun.Enums;
using System;

namespace ExceptionRun.Models
{
    public class Calculator
    {
        public int Calculate(Operation operation, int num1, int num2)
        {
            switch (operation)
            {
                case Operation.Addition:
                    return num1 + num2;
                case Operation.Subtraction:
                    return num1 - num2;
                case Operation.Multiplication:
                    return num1 * num2;
                case Operation.Division:
                    return num1 / num2;
                case Operation.Unknown:
                    throw new ArgumentException();
                default:
                    throw new ArgumentException($"{operation} is not an even Operation");
            }
        }
    }
}
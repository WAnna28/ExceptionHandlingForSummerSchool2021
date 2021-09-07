using ExceptionRun.Enums;

namespace ExceptionRun.ExtensionMethods
{
    static class OperationExtension
    {
        public static Operation ToOperation(this string stringOperation)
        {
            switch (stringOperation)
            {
                case "+":
                case "addition":
                    return Operation.Addition;
                case "-":
                case "subtraction":
                    return Operation.Subtraction;
                case "*":
                case "multiplication":
                    return Operation.Multiplication;
                case "/":
                case "division":
                    return Operation.Division;
                default:
                    return Operation.Unknown;
            }
        }
    }
}
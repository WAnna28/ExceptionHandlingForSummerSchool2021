using System;

namespace ExceptionLib
{
    [Serializable]
    public class CalculationException : Exception
    {
        private static readonly string defaultMessage = "An error occurred during calculation in the ExceptionHandlingForSummerSchoolLib.";

        public CalculationException() { }
        public CalculationException(string message) : base(message) { }
        public CalculationException(string message, Exception inner) : base(message, inner) { }
        protected CalculationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message
        {
            get
            {
                return base.Message + Environment.NewLine + defaultMessage;
            }
        }
    }

    //Exception    

    // Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file.
    // Its main purpose is to save the state of an object in order to be able to recreate it when needed.
    // The reverse process is called deserialization.

    //[Serializable]
    //public class MyException : Exception
    //{
    //    public MyException() { }
    //    public MyException(string message) : base(message) { }
    //    public MyException(string message, Exception inner) : base(message, inner) { }
    //    protected MyException(
    //      System.Runtime.Serialization.SerializationInfo info,
    //      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    //}
}
using System;

namespace SimpleCalculator
{
    public class Operation
    {
        public static double Add(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }

        public static double Subtract(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }
        public static double Multiply(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }

        public static double Divide(double firstOperand, double secondOperand)
        {
            return secondOperand == 0? throw new ArithmeticException() :
                firstOperand / secondOperand;
        }
    }
}
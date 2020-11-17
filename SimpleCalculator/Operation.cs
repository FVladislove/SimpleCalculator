using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public class Operation : TestClass
    {
        public Operation()
        {
        }
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
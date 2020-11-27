using System;
using System.Collections.Generic;
using System.Text;

namespace Enhetstestning.math
{
    public class MyMath
    {
        public static decimal Add(string num1, string num2)
        {
            // OverflowException (vid för höga/ låga tal)
            // FormatException (vid input: ingenting/ sträng )
            try
            {
                var num1Dec = Convert.ToDecimal(num1);
                var num2Dec = Convert.ToDecimal(num2);
            }
            catch (Exception)
            {

                throw;
            }

            return num1Dec + num2Dec;
        }

        //public static string Sub(string num1, string num2)
        //{
        //    return num1 - num2;
        //}

        //public static string Div(string num1, string num2)
        //{
        //    try
        //    {
        //        return num1 / num2;
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        throw new Exception("Can not divide by zero.");
        //    }
            
        //}

        //public static string Mul(string num1, string num2)
        //{
        //    return num1 * num2;
        //}

        //public static double Pow(string num1, string num2)
        //{
        //    return Math.Pow(num, power);
        //}
    }
}

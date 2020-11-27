using System;
using Enhetstestning.math;

namespace Enhetstestning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ange första tal: ");
                var num1 = Console.ReadLine();
                Console.Write("Ange andra tal: ");
                var num2 = Console.ReadLine();

                var calculate = new
                {
                    Add = MyMath.Add(num1, num2),
                    //Sub = MyMath.Sub(num1, num2),
                    //Mul = MyMath.Mul(num1, num2),
                    //Div = MyMath.Div(num1, num2),
                    //Pow = MyMath.Pow(num1, num2)
                };

                Console.WriteLine(calculate);
                Console.ReadKey();
            }
        }
    }
}

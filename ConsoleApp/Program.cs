using System;
using DivisionException;
using ArrayException;

namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Division obj = new Division();//division class object

            Console.WriteLine("Divide by 0 Exception :");

            Console.WriteLine("Enter the value of divident");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            obj.Divide(divident,divisor);//calling division class function

            ArrayClass ob = new ArrayClass();//array class object

            Console.WriteLine("Array out of bound Exception :");

            ob.CalculateSum();

            Console.ReadLine();
        }
    }
}

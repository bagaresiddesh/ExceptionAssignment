using System;

namespace DivisionException
{
    public class Division
    {
        public int result = 0;
        public void Divide(int num1,int num2)
        {
            try
            {
                result = num1 / num2;
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("exception caught {0} : ", e);
            }

            finally
            {
                Console.WriteLine("Result {0} : ", result);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ArrayException
{
    public class ArrayClass
    {
        public void CalculateSum()
        {
            int sum = 0;

            int[] number = new int[5] {1,2,3,4,5};

            try
            {
                for(int i=1;i<=number.Length;i++)
                {
                    sum = sum + number[i];
                }
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

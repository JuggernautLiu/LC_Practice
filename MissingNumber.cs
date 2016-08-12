using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC_Practice
{
    public class MissingNumber
    {
        public int FindMissingDuplicateNumber(int[] Arr)
        {
            Console.WriteLine("Call FindMissingDuplicateNumber >>>");
            int ret = 0;
            int XORValue = 0;

            foreach(int i in Arr)
            {
                XORValue=XORValue^i;
                Console.WriteLine("XORValue = "+XORValue);
            }
            ret = XORValue;
            Console.WriteLine("XORValue = "+XORValue);


            Console.WriteLine("Call FindMissingDuplicateNumber <<<");
            
            return ret;
        }

        public int FindMissingNumber(int[] Arr)
        {
            Console.WriteLine("Call FindMissingNumber >>>");
            int ret = 0;
            int len = Arr.Length;
            int XORValue = 0;

            for(int i =0 ; i<len ;i++)
            {
                XORValue=XORValue^i;
                Console.WriteLine("XORValue = "+XORValue);
            }
            ret = XORValue;
            Console.WriteLine("XORValue = "+XORValue);


            Console.WriteLine("Call FindMissingNumber <<<");
            
            return ret;
        }

        /*
        public double FindMissingDuplicateNumber(double[] Arr)
        {
            Console.WriteLine("Call FindMissingDuplicateNumber >>>");
            double ret = 0;
            double XORValue = 0.0;

            foreach(double i in Arr)
            {
                XORValue=XORValue^i;
                Console.WriteLine("XORValue = "+XORValue);
            }
            ret = XORValue;
            Console.WriteLine("XORValue = "+XORValue);


            Console.WriteLine("Call FindMissingDuplicateNumber <<<");
            
            return ret;
        }
        */
    }
}

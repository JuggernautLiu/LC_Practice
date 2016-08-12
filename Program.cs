using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LC_Practice;

namespace LC_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test_RemoveDupSortedArray();
            Test_MergeSortedArray();
            Test_SumII();
            Test_MissingNumber_FindMissingDuplicateNumber();
            Test_MissingNumber_FindMissingNumber();

        }

        public static void Test_RemoveDupSortedArray()
        {
            RemoveDupSortedArray rd = new RemoveDupSortedArray();
            int[] arr1 = new int[]{1,1,2,2,3,4,5,5};
            int expected = 5;
            int act = rd.removeDuplicates(ref arr1);
            bool bPass = (expected==act);
            Console.WriteLine("Result : "+bPass + "  ; Expected = "+expected+" ; Act ="+act);
        }

        public static void Test_MergeSortedArray()
        {
            MergeSortedArray ms = new MergeSortedArray();
            int[] arr1 = new int[8];
            arr1[0] = 1;
            arr1[1] = 3;
            arr1[2] = 4;
            arr1[3] = 9;
            int[] arr2 = new int[]{2,5,7,8};
            int[] expected = new int[]{1,2,3,4,5,7,8,9};
            ms.merge(ref arr1,4,arr2);
            //mergeA(ref arr1, 4, arr2);
            bool bPass = true;

            for (int i = 0; i < expected.Length; i++)
            {
                if(expected[i] != arr1[i])
                {
                    Console.WriteLine("expected : "+expected[i]+" != arr1 : "+arr1[i]);
                    bPass = false;
                    break;
                }
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);                
            }
            Console.WriteLine(" ");
            Console.WriteLine("Result : "+bPass);
        }

        public static void Test_SumII()
        {
            int[] para = new int[]{2,7,4,8};
            int target = 9;
            Sum sum = new Sum();
            int[] act = sum.SumII(para, target);
            int[] expected = new int[]{2,7};

            bool bPass = true;
            for (int i = 0; i < expected.Length; i++)
            {
                Console.Write("act ["+i+"]="+act[i]+" ; exp["+i+"]="+expected[i]);
                if(act[i] != expected[i])
                {
                    bPass = false;
                    break;
                }
            }
            Console.WriteLine(bPass);

        }

        public static void Test_MissingNumber_FindMissingDuplicateNumber()
        {
            int[] para = new int[]{2,2,3,1,1};
            
            MissingNumber miss = new MissingNumber();
            int act = miss.FindMissingDuplicateNumber(para);
            int expected = 3;

            bool bPass = (act==expected);
            Console.WriteLine(bPass);

        }

        public static void Test_MissingNumber_FindMissingNumber()
        {
            int[] para = new int[]{4,2,1,0};
            
            MissingNumber miss = new MissingNumber();
            int act = miss.FindMissingDuplicateNumber(para);
            int expected = 3;

            bool bPass = (act==expected);
            Console.WriteLine(bPass);

        }
    }
}

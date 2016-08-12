using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC_Practice
{
    public class MergeSortedArray
    {
 /*
Given two sorted integer arrays A and B, merge B into A as one sorted array.
Note: You may assume that A has enough space (size that is greater or equal to m + n) to hold additional elements from B. 
The number of elements initialized in A and B are m and n respectively.
*/
        public void merge(ref int[] ArrA, int validAcount, int[] ArrB)
        {
            Console.WriteLine("Call mergeA >>>");
            do
            {
                if(ArrA==null && ArrB==null)
                {
                    Console.WriteLine("A & B == NULL");
                    break;
                }

                if(ArrA==null)
                {
                    Console.WriteLine("A == NULL");
                    ArrA = ArrB;
                    break;
                }           
                if(ArrB==null)
                {
                    Console.WriteLine("B == NULL");
                    break;
                }
                
                int A_count = validAcount;
                int B_count = ArrB.Length;

                int Index_All = A_count + B_count - 1;
                int Index_A = A_count - 1;
                int Index_B = B_count - 1;

                Console.WriteLine("A len="+A_count+"B len="+B_count);
                Console.WriteLine("Index_All :"+Index_All+" ; Index_A :"+Index_A+" ; Index_B :"+Index_B);

                while(Index_All >= 0)
                {
                    Console.WriteLine("Index_All :"+Index_All+" ; Index_A :"+Index_A+" ; Index_B :"+Index_B);
                    if(Index_A < 0)
                    {
                        ArrA[Index_All] = ArrB[Index_B--];
                        Console.WriteLine(ArrA[Index_All]);
                        Index_All--;
                        continue;
                    }

                    if(Index_B < 0)
                    {
                        ArrA[Index_All] = ArrA[Index_A--];
                        Console.WriteLine(ArrA[Index_All]);
                        Index_All--;
                        continue;
                    }

                    if(ArrA[Index_A] > ArrB[Index_B])
                    {
                        ArrA[Index_All] = ArrA[Index_A--];
                    }
                    else
                    {
                        ArrA[Index_All] = ArrB[Index_B--];
                    }
                    Console.WriteLine(ArrA[Index_All]);
                    Index_All--;
                }
            } while (false);
            
        }
    }
}

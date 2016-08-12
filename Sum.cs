using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC_Practice
{
    public class Sum
    {
 /*
Given an array of intergers, find two numbers such that they add up to a specific target number. 
The function twoSum should return indices of the two numbers such that they add up to the target, 
where index1 must be less than index2 Please note that your returned answers 
(both index1 and index2) are not zero-based.
You may assume that each input would have exactly one solution.
Input: numbers={2, 7, 11, 15}, target=9 Output: index1=1, index2=2
*/
        public int[] SumII(int[] ArrA, int target)
        {
            Console.WriteLine("Call SumII >>>");
            int[] ret = new int[2];

            HashSet<int> HashArrA = new HashSet<int>();
            int Len_ArrA = ArrA.Length;
            for (int i = 0; i < Len_ArrA; i++)
            {
                HashArrA.Add(ArrA[i]);
            }

            for (int j = 0; j < Len_ArrA; j++)
            {
                int anotherNum = target - ArrA[j];
                if(HashArrA.Contains(anotherNum))
                {
                    if(anotherNum < ArrA[j])
                    {
                        ret[0] = anotherNum;
                        ret[1] = ArrA[j];
                    }
                    else
                    {
                        ret[0] = ArrA[j];
                        ret[1] = anotherNum;                                                
                    }
                }
            }

        
            return ret;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC_Practice
{
    public class RemoveDupSortedArray
    {
 /*
Given a sorted array, remove the duplicates in place such that > each element appear only once and return the new length.
Do not allocate extra space for another array, you must do this in place with constant memory.
For example, Given input array A = [1,1,2],
Your function should return length = 2, and A is now [1,2].
*/
        public int removeDuplicates(ref int[] OriArr)
        {
            int currentCount = 0;
            
            do
            {
                if(OriArr==null)
                {
                    currentCount=0;
                    break;
                }
                
                int oriCount = OriArr.Length;
                if(oriCount==1)
                {
                    currentCount = oriCount;
                    break;
                }
                
                //int previous = Int32.MinValue;
                currentCount=1;
                for(int i=1;i<oriCount ; i++)
                {
                    if(OriArr[i] > OriArr[i-1])
                    {
                        currentCount++;
                    }
                }

            } while (false);

            return currentCount;
        }

        
    }
}

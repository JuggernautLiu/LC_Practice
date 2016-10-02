using System;
using System.Collections.Generic;

namespace LC_Practice
{
    public class quicksort
    {
        public void Test_run_qsort()
        {
            
        }
        public void run_qsort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int pivot = array[(left+right)/2];
                int leftIndex = left - 1;
                int rightIndex = right + 1;
                while(true)
                {
                    while(array[++leftIndex] < pivot);
                    while(array[--rightIndex] > pivot);
                    if(leftIndex >= rightIndex)
                        break;

                    SWAP(array, leftIndex, rightIndex);
                }
                run_qsort(array, left, leftIndex-1);
                run_qsort(array, rightIndex+1,right);
            }
            
        }

        public void SWAP(int[] array, int i, int j)
        {
            array[i] = array[i] ^ array[j];
            array[j] = array[i] ^ array[j];
            array[i] = array[i] ^ array[j];
        }
    }

}
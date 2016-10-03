using System;
//using System.Collections.Generic;
//using System.Linq;


namespace LC_Practice
{   public class AMZTest2_ReturnDuplicateString  
    {
        // use 2 for loop
        public string GetDuplicateString_1(string input)
        {
            // sample 
            // input : abcde_ab_bcd_ef
            // output : bcd
            
            string ret = String.Empty;
            char[] arr = input.ToCharArray();
            int len = arr.Length;
            string max_String = String.Empty;
            int max_Len = 0;
            for(int i=0 ; i<len ; i++)
            {
                for(int j=i+1;j<len;j++)
                {
                    if(arr[i] == arr[j])
                    {
                        int tmpLen = 0;
                        string tmpStr = arr[j].ToString();
                        int iIndex = i+1;
                        int jIndex = j+1;
                        while(true)
                        {
                            if(arr[iIndex] == arr[jIndex])
                            {
                                tmpLen++;
                                tmpStr += arr[jIndex].ToString();
                                iIndex++;
                                jIndex++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if(tmpLen > max_Len)
                        {
                            max_String = tmpStr;
                            max_Len = tmpLen;
                        }
                    }

                }
            }
            ret = max_String;
            return ret;
        }
    }
}
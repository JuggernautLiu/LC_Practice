using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC_Practice
{
    // #409
    public class LongestPalindrome
    {
        public int getLongestPalindrome(string s) 
        {
            int ret = 1;
            char[] arr = s.ToCharArray();
            int len = arr.Length;
            Dictionary<char,int> Dics = new Dictionary<char,int>();

            for(int i=0 ; i< len ; i++)
            {
                if(Dics.ContainsKey(arr[i]))
                {
                    Dics[arr[i]]++;
                }
                else
                {
                    Dics[arr[i]] = 1;
                }
            }

            int tmpRet = 0;
            bool bNotAdd = true;
            foreach(int count in Dics.Values)
            {
                if(count >= 2)
                {
                    if(count % 2==0)
                    {
                        tmpRet += count;
                    }
                    else
                    {
                        if(bNotAdd)
                        {
                            tmpRet += count;
                            bNotAdd = false;
                        }
                        else
                        {
                            tmpRet += (count-1);
                        }
                    }
                    
                }
                else
                {
                    if(bNotAdd)
                    {
                        tmpRet+=1;
                        bNotAdd = false;
                    }
                }
            }
            ret = tmpRet;
            return ret;
        
        }
    }
}
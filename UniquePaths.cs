using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC_Practice
{
    public class UniquePath
    {
        /*
        A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?
*/

        //https://leetcode.com/problems/unique-paths/
        public int UniquePaths_LC_61(int m, int n)
        {
            // check boundary
            if(m == 0 || n ==0)
                return 0;
            
            if(m == 1 || n == 1 )
                return 1;
            
            // init m * n 2-dimensions array
            int[,] pathArray = new int[m,n];
            // init [0,*] and [*,0]
            for(int x=0 ; x<n ; x++)
            {
                pathArray[0,x] = 1;
            }
            for(int y=0 ; y<m ; y++)
            {
                pathArray[y,0] = 1;
            }
        
            // DP
            for(int y=1 ; y<m ; y++)
            {
                for(int x=1 ; x<n ; x++)
                {
                    pathArray[y,x] = pathArray[y,x-1] + pathArray[y-1,x];
                }
            }
        
        
        
            // print 
            for(int y=0 ; y<m ; y++)
            {
                Console.WriteLine("Row = "+y);
                for(int x = 0 ; x<n ; x++)
                {
                    Console.Write(pathArray[y,x]);
                    Console.Write(" , ");
                }
            }
            return pathArray[m-1,n-1];
        }

        /*
        Follow up for "Unique Paths":

Now consider if some obstacles are added to the grids. How many unique paths would there be?

An obstacle and empty space is marked as 1 and 0 respectively in the grid.

For example,
There is one obstacle in the middle of a 3x3 grid as illustrated below.
https://leetcode.com/problems/unique-paths-ii/
        */

        public int UniquePathsWithObstacles_LC_62(int[,] obstacleGrid)
        {
             int Xaxle = obstacleGrid.GetLength(1);
            int Yaxle = obstacleGrid.GetLength(0);
            Console.WriteLine("X axle = {0}",Xaxle);
            Console.WriteLine("Y axle = {0}",Yaxle);
            int[] currentRow = new int[Xaxle];
            int[] lastRow = new int[Xaxle];
        
            // check boundary
            if(Xaxle==0 || Yaxle==0)
                return 0;
            if(Xaxle==1 && Yaxle==1 && obstacleGrid[0,0]==0)
                return 1;
            if(Xaxle==1 && Yaxle==1 && obstacleGrid[0,0]==1)
                return 0;
            
        
            // Init first row and first column
            bool bstone = false;
            for(int x=0 ; x<Xaxle ; x++)
            {
                if(bstone)
                {
                    currentRow[x]= 0;
                    continue;
                }
                else if (obstacleGrid[0,x]==1)
                {
                    bstone = true;
                    currentRow[x]= 0;
                }
                else
                {
                    currentRow[x]= 1;
                }
                // print
                Console.Write("{0} ,",currentRow[x]);
            }
        
            Console.WriteLine("Start DP ==>");
            for(int y=1 ; y<Yaxle ; y++)
            {
                Console.WriteLine("Row {0} :",y);
                // deal with first column
                if(obstacleGrid[y,0]==1)
                {
                    currentRow[0]= 0;
                }
                else
                {
                    currentRow[0]= 0 + currentRow[0];
                }
            
                for(int x=1 ; x<Xaxle ; x++)
                {
                    if (obstacleGrid[y,x]==1)
                    {
                        //bstone = true;
                        currentRow[x]= 0;
                    }
                    else
                    {
                        currentRow[x]= currentRow[x-1] + currentRow[x];
                    }
                    // print
                    Console.Write("{0} ,",currentRow[x]);
                
                }
                Console.WriteLine(" ");
                Console.WriteLine("Finish Row {0}",y);
            }
            return currentRow[Xaxle-1];
        }
    }
}
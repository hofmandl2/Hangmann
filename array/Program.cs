using System;
using System.Collections.Generic;

name space Array
{
    class Array
    {
        static void Main(string[] arg)
        {
            int[][] array = new int[16][3];
            for(int i = 0; i<16;i++)
            {
                for(int j = 0; j<3; j++)
                {
                    array[i][j] = array[i][j]; 
                }
            }

            for(int i = 0; i<16;i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.WriteLine(array[i][j]); 
                }
            }
            
        }   
    }
}
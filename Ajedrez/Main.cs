using System;
using System.Collections.Generic;

namespace Ajedrez
{
    class Ajedrez
    {
        static void Main(string[]arg)
        {
            string[,] tablero = new string[8,8];
            string reina = " ♔ ";
            
            for(int i = 0; i<8; i++)
            {
                for(int j = 0; j<8; j++)
                {
                    if(i%2 ==0 && j%2 == 0 || i%2 !=0 && j%2 != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(tablero[i,j] = " 1 ");
                        Console.BackgroundColor = ConsoleColor.Black;    
                    }
                    else{
                    
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(tablero[i,j] = reina);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    
                    
                }
                Console.WriteLine();
            }
        }
    }
}
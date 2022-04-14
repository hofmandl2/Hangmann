using System;
using System.Collections.Generic;
using clasePiezas;

namespace Ajedrez_main
{
    class Ajedrez
    {
        
        static void Main(string[] arg)
        {
            Logic logic = new Logic();
            logic.start();
        }
        class Logic
        {   
            Piezas piezas = new Piezas();
            public void start()
            {
                string[,] tablero = new string[8, 8];

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0 || i % 2 != 0 && j % 2 != 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(piezas.getPiezas("Torre"));
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else{

                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(piezas.getPiezas("Reina"));
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    Console.WriteLine();
                }
               
                Console.ForegroundColor = ConsoleColor.White;
            }
            /*public void start()
            {
                
            }*/
                
        }

    } 
}

using System;
using System.Collections.Generic;
using clasePiezas;
using System.Threading.Tasks;
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
            string[,] tablero = new string[8, 8];
            public Logic()
            {
                
                tablero[0,1] = " 0 ";
                //relleno el tablero vacio
                for(int i = 0; i<8; i++)
                {
                    for(int j = 0; j<8; j++)
                    {   
                        tablero[i,j] = "  ";
                    }
                }
                tablero[7,0] = piezas.getPiezas("Torre");
                
            }
            public void start()
            {
                while(true)
                {
                        boardImpress();
                        Thread.Sleep(2000);
                }
            }
            private void boardImpress()
            {
                                    Console.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (i % 2 == 0 && j % 2 == 0 || i % 2 != 0 && j % 2 != 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(tablero[i,j]);
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else{

                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(tablero[i,j]);

                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }
                        Console.WriteLine();
                    }
            }
        }     

    } 
}

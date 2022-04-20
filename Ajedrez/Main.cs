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
                        if(i == 1 && j < 8)
                        {
                            tablero[i,j] = piezas.getPiezas("Peon");
                        }
                    }
                }

                tablero[piezas.getCoordinat_piezas_negras("TorreIi"),piezas.getCoordinat_piezas_negras("TorreIj")] = piezas.getPiezas("Torre");
                tablero[piezas.getCoordinat_piezas_negras("ArfilBi"),piezas.getCoordinat_piezas_negras("ArfilBj")] = piezas.getPiezas("Arfil");
                tablero[piezas.getCoordinat_piezas_negras("Caballo1i"),piezas.getCoordinat_piezas_negras("Caballo1j")] = piezas.getPiezas("Caballo");
                tablero[piezas.getCoordinat_piezas_negras("Reyi"),piezas.getCoordinat_piezas_negras("Reyj")] = piezas.getPiezas("Rey");
                tablero[piezas.getCoordinat_piezas_negras("Reinai"),piezas.getCoordinat_piezas_negras("Reinaj")] = piezas.getPiezas("Reina");
                tablero[piezas.getCoordinat_piezas_negras("Caballo2i"),piezas.getCoordinat_piezas_negras("Caballo2j")] = piezas.getPiezas("Caballo");
                tablero[piezas.getCoordinat_piezas_negras("ArfilNi"),piezas.getCoordinat_piezas_negras("ArfilNj")] = piezas.getPiezas("Arfil");
                tablero[piezas.getCoordinat_piezas_negras("TorreDi"),piezas.getCoordinat_piezas_negras("TorreDj")] = piezas.getPiezas("Torre");
                

                
            }
            public void start()
            {
                
                while(true)
                {
                        boardImpress();
                        Console.WriteLine(piezas.getCoordinat_piezas_negras("Reyi"));
                        piezas.setCoordinat_piezas_negras("Reyi","Reyj",1,1);
                        Console.WriteLine(piezas.getCoordinat_piezas_negras("Reyi"));
                        Thread.Sleep(2000);
                }
            }
            private void boardImpress()
            {
                    //Console.Clear();
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
                                Console.ForegroundColor = ConsoleColor.Black;
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

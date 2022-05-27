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
           Icon_Piezas piezas = new Icon_Piezas();
           Caballo caballoNegro = new Caballo();
           Caballo caballoBlanco = new Caballo();
           
           string vacio = " ♜ ";
        
           
            string[,] tablero = new string[8, 8];
            public void start()
            {
                caballoNegro.setCoordenada(2,1);
                
                while(true)
                {
                    caballoNegro.move();
                    rellenoTableroFichasInit();//relleno que se actuliza con cada frame
                    boardImpress();
                    
                    
                    
                    //Console.WriteLine("{0}",caballoNegro.getCoordenadax());
                    
                    Console.Write(caballoNegro.moveImpres()+" : ");
                    caballoNegro.vaciadoDeLista();
                    Thread.Sleep(1000);
                }
            }
            private void boardImpress()
            {
                    //int contadorx = 0;
                    //int contadory = 0;
                    Console.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (i % 2 == 0 && j % 2 == 0|| i % 2 != 0 && j % 2 != 0)
                            {
                                                           
                                Console.BackgroundColor = ConsoleColor.Blue;
                                if(tablero[i,j] == vacio)
                                { 
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{tablero[i,j]}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    
                                }
                                /*else if(piezas.soyBlanca(i,j))
                                { 
                                   //Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                   // Console.BackgroundColor = ConsoleColor.Black;
                                }
                                else if(piezas.soyNegra(i,j))
                                {                            
                                    //Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    //Console.BackgroundColor = ConsoleColor.Black;
                                }*/
                                else if(tablero[i,j] != caballoNegro.getIcono())
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                            }    
                            else
                            {
                                    
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                if(tablero[i,j] == vacio)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                /*else if(piezas.soyNegra(i,j))
                                {
                                    //Console.BackgroundColor = ConsoleColor.Cyan;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    //Console.BackgroundColor = ConsoleColor.Black;
                                
                                 }
                                 else if(piezas.soyBlanca(i,j))
                                 {
                                    //Console.BackgroundColor = ConsoleColor.Cyan;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    //Console.BackgroundColor = ConsoleColor.Black;
                                  }*/
                                else if(tablero[i,j] != caballoNegro.getIcono())
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(tablero[i,j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                
                                Console.BackgroundColor = ConsoleColor.Black;
                                                                        
                            }
                                
                            
                        }
                        Console.WriteLine();
                        //contadory++;
                    }
            }
            void rellenoTableroFichasInit()
            {   
                if(caballoNegro.getCoordenadax() <=7 && caballoNegro.getCoordenadax() >=0 && caballoNegro.getCoordenaday() >=0 && caballoNegro.getCoordenaday() <=7 )
                {
                    tablero[caballoNegro.getCoordenadax(),caballoNegro.getCoordenaday()] = caballoNegro.icono;
                }
                /*if(caballoNegro.move %2 == 0)
                {
                    
                }else
                {
                    
                }*/
                //relleno el tablero vacio
                for(int i = 0; i<8; i++)
                {
                    for(int j = 0; j<8; j++)
                    {   
                        /*if(!piezas.soyBlanca(i,j) && !piezas.soyNegra(i,j)) 
                        {
                            tablero[i,j] = vacio;
                            
                        }*/
                        if(i != caballoNegro.getCoordenaday() && j !=caballoNegro.getCoordenadax())
                        {
                            tablero[i,j] = vacio;

                        }
                    }
                }
            }
       }
    }
}

        

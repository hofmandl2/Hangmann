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
    }
    class Logic
    {
        //Constructores
        clasePiezas.Icon_Piezas icon = new clasePiezas.Icon_Piezas();
        clasePiezas.Torre torre = new Torre();
        clasePiezas.Piezas piezas = new clasePiezas.Piezas();

        string vacio = " ♜ ";
        public int[,] cordenadasNegras = new int[16, 2];
        public int[,] cordenadasBlancas = new int[16, 2];
        public string[,] tablero = new string[8, 8];

        public void start() //Bucle inicial
        {
            rellenodecordenadasNegras();
            rellenodecordenadasBlancas();
            torre.move(cordenadasBlancas[0,0],cordenadasBlancas[0,1]);
            boardrelleno();
            boarImpress();
        }
        /// <summary>
        /// Metodos para el funcinamiento
        /// </summary>
        //Negras
        void rellenodecordenadasNegras()
        {   
            //Torre
            cordenadasNegras[0, 0] = 0; //y
            cordenadasNegras[0, 1] = 0; //x
            //Arfil Izquierda
            cordenadasNegras[0, 2] = 0; //y
            cordenadasNegras[0, 3] = 1; //x


        }
        bool soyNegra(int y, int x)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (cordenadasNegras[0, 0] == y && cordenadasNegras[0, 1] == x)
                    { return true; }
                }
            }
            return false;
        }
        //Blancas
        void rellenodecordenadasBlancas()
        {
            cordenadasBlancas[0, 0] = 7;
            cordenadasBlancas[0, 1] = 0;
        }
        bool soyBlanca(int y, int x)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (cordenadasBlancas[0, 0] == y && cordenadasBlancas[0, 1] == x)
                    { return true; }
                }
            }
            return false;
        }
        //Relleno del tablero, cordenadas y espacios vacios
        void boardrelleno()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tablero[i, j] = vacio;
                }
            }
            //Fichas Negras
            tablero[cordenadasNegras[0, 0], cordenadasNegras[0, 1]] = icon.getPiezas("Torre");
            //Fichas Blancas
            tablero[cordenadasBlancas[0, 0], cordenadasBlancas[0, 1]] = icon.getPiezas("Torre");
        }

        void boarImpress()//Impresion del tablero
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i);

                for (int j = 0; j < 8; j++)
                {
                    if (j % 2 == 0 && i % 2 == 0 || j % 2 != 0 && i % 2 != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        if (tablero[i, j] == vacio)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (soyNegra(i, j))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (soyBlanca(i, j))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (tablero[i,j] == piezas.getCasillaIcon())
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        if (tablero[i, j] == vacio)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (soyNegra(i, j))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (soyBlanca(i, j))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (tablero[i, j] == piezas.getCasillaIcon())
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(tablero[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.WriteLine(" ");

            }
            char letra = 'A';
            for (int i = 0; i < 8; i++)
            {
                Console.Write(" " + letra + " ");
                letra++;
            }
        }
    }
}


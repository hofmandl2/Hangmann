using System;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Número Mágico 
            El juego consiste en lo siguiente: 
            Se debe asignar a cada persona su número mágico, que se obtienen con la siguiente regla: se suman los dígitos de la fecha de nacimiento y se suman nuevamente los dígitos del resultado hasta obtener un solo digito como en el siguiente ejemplo: 
            Fecha de Nacimiento: 04 de abril de 1973 
            04+04+1973=1981 entonces 1+9+8+1= 19 entonces 1+9= 10 entonces 1+0=1 
            Entonces el número buscado es 1, 
            Lea tres números: día, mes y año y muestre el número del tarot correspondiente*/

            /*int dia, mes, año, numero_magico;
            string numero_magico_string;



            
            while(true)
            {
                Console.Write("Porfavor ingrese su dia de nacimiento: ");
                dia = int.Parse(Console.ReadLine());
            
                Console.Write("Porfavor ingrese su mes de nacimiento: ");
                mes = int.Parse(Console.ReadLine());
            
                Console.Write("Porfavor ingrese su año de nacimiento: ");
                año = int.Parse(Console.ReadLine());

                numero_magico = dia+mes+año;
                numero_magico_string = Convert.ToString(numero_magico);
                numero_magico = 0;
                for(int i = 0; i<numero_magico_string.Length; i++)
                { 
                    numero_magico += int.Parse(numero_magico_string.Substring(i,1));
                }
                break;
            }
            Console.WriteLine($"Su numero es: {numero_magico}");*/
            /*string clave = Console.ReadLine();
            Console.WriteLine("\n"+encriptar(clave));
            

            string encriptar(string clave)
            {

                int valor;
                int N_clave = 0;

                for (int i = 0; i < clave.Length; i++)
                {
                    valor = 0;
                    valor = Convert.ToChar(clave.Substring(i, 1));
                    N_clave = N_clave + valor;
                    Console.Write(N_clave + ": ");
                }

                N_clave = 5000 - N_clave + clave.Length;

                string c_clave = Convert.ToString(N_clave);

                return c_clave;
            }

            string desinciptador(int clave_incriptada)
            {
            }
            char palabra;
            int conversion = 71;
            
            palabra = Convert.ToChar(conversion);
            Console.Write(palabra);
          	*/

            /*Caso de prueba 3: Matrices 
            El movimiento del caballo en un tablero de ajedrez se da en forma de L, si tenemos un ajedrez de (8x8) casillas, diseñe un algoritmo que lea las coordenadas con la ubicación de un caballo en ese tablero, muestre como resultado una matriz con las celdas marcadas con el valor 1 para indicar las casillas a las que se puede mover el caballo. 
            El caballo puede moverse entre casillas: dos en una dirección y una en una dirección perpendicular. Considere los límites del tablero*/

            string[,] tablero = new string[8,8];
            int[] posicion_caballo = new int[2];
            //posibles pos
            int[] pos1 = new int[2];
            int[] pos2 = new int[2];
            int[] pos3 = new int[2];
            int[] pos4 = new int[2];
            int[] pos5 = new int[2];
            int[] pos6 = new int[2];
            int[] pos7 = new int[2];
            int[] pos8 = new int[2];

            string posicion;
            int index_de_relleno = 1;//para rellenar la matriz
            //
            rellenar_Tablero_Numeros();
            imprimir_Tablero();
            Console.WriteLine("Que posicion quiere? ");
            posicion = Console.ReadLine();
            while(posicion != "q"){

                if(int.Parse(posicion) < 10)
                {
                    posicion = $"| {posicion} |";
                    econtrarPosicion(posicion);
                }
                else {posicion = $"{posicion} |"; }
                econtrarPosicion(posicion);
                rellenar_Tablero("-");
                tablero[posicion_caballo[0],posicion_caballo[1]] = "| A |";
                calculoPosiciones(posicion_caballo[0],posicion_caballo[1]);
                imprimir_Tablero();
                Console.Write("En que posicion quiere saltar? Elija un numero\nSi desea salir oprima 'q': ");
                posicion = Console.ReadLine();

            }
            //metodo de calculo para la siguiente posicion

            void calculoPosiciones(int pos_y,int pos_x)
            {
                //pos1
                if(pos_x-2 >= 0 && pos_y-1 >= 0 )
                { 
                    pos1[1] = pos_x-2;
                    pos1[0] = pos_y-1;
                    tablero[pos1[0],pos1[1]] = "| 1 |";
                }
                //pos2
                if(pos_x-1 >= 0 && pos_x-1 <= 7 && pos_y-2 >= 0 && pos_y-2 <= 7)
                {
                    pos2[1] = pos_x-1;
                    pos2[0] = pos_y-2;
                    tablero[pos2[0],pos2[1]] = "| 2 |";
                }
                //pos3
                if(pos_x+1 >= 0 && pos_x+1 <= 7  && pos_y+2 >= 0 && pos_y+2 <= 7)
                {
                    pos3[1] = pos_x+1;
                    pos3[0] = pos_y-2;
                    tablero[pos3[0],pos3[1]] = "| 3 |";
                }
                //pos4
                if(pos_x+2>= 0 && pos_x+2 <= 7 && pos_y+1 >= 0 && pos_y+1 <= 7)
                {
                    pos4[1] = pos_x+2;
                    pos4[0] = pos_y-1;
                    tablero[pos4[0],pos4[1]] = "| 4 |";
                }
                //pos5
                if(pos_x+2 >= 0 && pos_x+2 <= 7 && pos_y+1 >= 0 && pos_y+1 <= 7)
                {
                    pos5[1] = pos_x+2;
                    pos5[0] = pos_y+1;
                    tablero[pos5[0],pos5[1]] = "| 5 |";
                }
                //pos6
                if(pos_x+1 >= 0 && pos_x+1 <= 7 && pos_y+2 >= 0 && pos_y+2 <= 7)
                {
                    pos2[1] = pos_x+1;
                    pos2[0] = pos_y+2;
                    tablero[pos2[0],pos2[1]] = "| 6 |";
                }
                //pos7
                if(pos_x-1 >= 0 && pos_x-1 <= 7 && pos_y+2 >= 0 && pos_y+2 <= 7)
                {
                    pos2[1] = pos_x-1;
                    pos2[0] = pos_y+2;
                    tablero[pos2[0],pos2[1]] = "| 7 |";
                }
                //pos8
                if(pos_x-2 >= 0 && pos_x-2 <= 7 && pos_y+1 >= 0 && pos_y+1 <= 7)
                {
                    pos2[1] = pos_x-2;
                    pos2[0] = pos_y+1;
                    tablero[pos2[0],pos2[1]] = "| 8 |";
                }
            }
            
            //Metodos
            void econtrarPosicion(string pos)
            {
                for(int i = 0; i<8; i++) 
                { 
                    for(int j = 0; j<8; j++)
                    {
                        if(tablero[i,j] == pos)
                        {
                            Console.WriteLine(i+ " : "+j);
                            posicion_caballo[0] = i; //posicion y
                            posicion_caballo[1] = j; //posicion x
                        }
                    }
                }
            }
            void imprimir_Tablero()
            {
                for(int i = 0; i<8; i++) //impresion
                { 
                    for(int j = 0; j<8; j++)
                    {
                        Console.Write($" {tablero[i,j]}");
                    }
                    Console.WriteLine();
                }
            }
            
            void rellenar_Tablero_Numeros()
            {
                for(int i = 0; i<8; i++) //relleno
                { 
                    for(int j = 0; j<8; j++)
                    {
                        if (index_de_relleno<10)
                        {
                            tablero[i,j] = $" {index_de_relleno} |";
                        }
                        else {tablero[i,j] = $"{index_de_relleno} |";}
                        index_de_relleno++;
                    }
                }
                Console.WriteLine();
            }
            
            void rellenar_Tablero(string clave)
            {
                for(int i = 0; i<8; i++) //relleno
                { 
                    for(int j = 0; j<8; j++)
                    {
                        tablero[i,j] = $"| {clave} |";
                    }
                    Console.WriteLine();
                }
            }
          }
    }
}

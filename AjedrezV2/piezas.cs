using System;
using System.Collections.Generic;

namespace clasePiezas
{
	public class Icon_Piezas
	{     
		public string getPiezas(string nombre_pieza)
	    {
	            	Dictionary<string, string> list_Piezas = list_Piezas = new Dictionary<string, string>()
	            	{
	                		{"Rey" , " ♔ "},
	                		{"Reina" , " ♕ "},
	                		{"Torre"," ♖ "},
	                		{"Arfil", " ♗ "},
	                		{"Caballo", " ♘ "}, 
	                 		{"Peon", " ♙ "}
	            	};
					return list_Piezas[nombre_pieza];	            	
		}
        
    }
    public class Piezas
    {
        public int coordx;
        public int coordy;
        string icono;
        public void setCoordenada(int x, int y)
        {
            coordx = x;
            coordy = y;
        }
        public int getCoordenadax()
        {
            return coordx;
        }
        public int getCoordenaday()
        {
            return coordy;
        }
        public string getIcono()
        {
            return icono;
        }
    }
    public class Caballo : Piezas
    {
        List<int> moves = new List<int>();
        
        public string icono = " ♘ ";
        public void move()
        {
            coordx-= 1;
            coordy-= 2;
            moves.Add(coordx);//primer move
            moves.Add(coordy);//
        }
        public void vaciadoDeLista()
        {
            moves.Clear();
        }
        public void moveImpres()
        {
            foreach(int i in moves)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
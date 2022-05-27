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
        public int coordx = 0;
        public int coordy = 0;
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
        public List<int> moves = new List<int>();
        
        public string icono = " ♘ ";
        
        public void move()
        {
            //int x;
            //int y;
            for(int i = 0; i <1; i++)
            {
                int x = coordx - 1;
                int y = coordy + 2;
                moves.Add(y);
                moves.Add(x);//primer move
                x = coordx - 2;
                y = coordy + 1;
                moves.Add(y);
                moves.Add(x);//segundo  move
            }
        }
        public void vaciadoDeLista()
        {
            moves.Clear();
        }
        public int moveImpres()
        { 
            for(int i = 0; i<moves.Count(); i++)
            {
                //Console.Write(i+":");
                return moves[i];
            }
            return moves[moves.Last()];
        }
    }
    
}
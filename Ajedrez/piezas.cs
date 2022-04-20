using System;
using System.Collections.Generic;

namespace clasePiezas
{
	public class Piezas
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
    public class Rey
    {
        /*public void move(pos_x, pos_y)
        {
            //move1
             
        }*/
    }
}
using System;
using System.Collections.Generic;
using Ajedrez_main;

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
    	Logic tablero = new Logic();
		string casillasParaMover = " ♟ ";

        public string getCasillaIcon()
		{
			return casillasParaMover;
		}

        public void torreMove(int y, int x)
    	{
    	    //Movimientos en el eje y hacia arriba
    	   	for(int i = 0; i < y; i++)
    		{
    	   		if (tablero.cordenadasBlancas[0, 1] - 1 > 0)
    	   		{
    				tablero.tablero[y,tablero.cordenadasBlancas[0, 1] - 1] = casillasParaMover;
    	   		}
    	   	}
    	}

	}
}
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
		//blancas
		Dictionary<string, int> coordinaten_blancas = new Dictionary<string, int>()
        {
                {"Reyi",0},{"Reyj",0},
                {"Reinai",1},{"Reinaj",1}

        };

		/*public int setCoordinat_piezas_blancas(string clave)
		{
			
		}*/
		public int getCoordinat_piezas_blancas(string clave)
        {
           
			return coordinaten_blancas[clave];
        }
		//negras
		Dictionary<string, int> coordinaten_negras = new Dictionary<string, int>()
        {
                {"TorreIi",0},{"TorreIj",0},
                {"ArfilBi",0},{"ArfilBj",1},
				{"Caballo1i",0},{"Caballo1j",2},
                {"Reyi",0},{"Reyj",3},
				{"Reinai",0},{"Reinaj",4},
                {"Caballo2i",0},{"Caballo2j",5},
				{"ArfilNi",0},{"ArfilNj",6},
                {"TorreDi",0},{"TorreDj",7}

        };
		public void setCoordinat_piezas_negras(string cordx,string cordy, int x,int y)
        {
           coordinaten_negras[cordx] = x;
		   coordinaten_negras[cordy] = y;
        }
		public int getCoordinat_piezas_negras(string clave)
        {
           
			return coordinaten_negras[clave];
        }
	}

}
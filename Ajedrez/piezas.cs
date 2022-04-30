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
                {"TorreIi",7},{"TorreIj",0},
                {"ArfilBi",7},{"ArfilBj",1},
				{"Caballo1i",7},{"Caballo1j",2},
                {"Reyi",7},{"Reyj",3},
				{"Reinai",7},{"Reinaj",4},
                {"Caballo2i",7},{"Caballo2j",5},
				{"ArfilNi",7},{"ArfilNj",6},
                {"TorreDi",7},{"TorreDj",7},
				{"Peon1i",6},{"Peon1j",0},
				{"Peon2i",6},{"Peon2j",1},
				{"Peon3i",6},{"Peon3j",2},
				{"Peon4i",6},{"Peon4j",3},
				{"Peon5i",6},{"Peon5j",4},
				{"Peon6i",6},{"Peon6j",5},
				{"Peon7i",6},{"Peon7j",6},
				{"Peon8i",6},{"Peon8j",7}
        };

		public void setCoordinatBlancasI(string cordI,int i)
		{
		    coordinaten_blancas[cordI] = i; //i
		}
  		public void setCoordinatBlancasJ(string cordJ,int j)
		{
		    coordinaten_blancas[cordJ] = j;
        }
		public int getCoordinat_piezas_blancas(string clave)
        {  
			return coordinaten_blancas[clave];
        }
		public bool soyBlanca(int i, int j)
		{
			
			if(coordinaten_blancas["TorreIi"] == i && coordinaten_blancas["TorreIj"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["ArfilBi"] == i && coordinaten_blancas["ArfilBj"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["Caballo1i"] == i && coordinaten_blancas["Caballo1j"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["ArfilNi"] == i && coordinaten_blancas["ArfilNj"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["TorreDi"] == i && coordinaten_blancas["TorreDj"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["Caballo2i"] == i && coordinaten_blancas["Caballo2j"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["Reyi"] == i && coordinaten_blancas["Reyj"] == j)
			{
				return true;
            }
			if(coordinaten_blancas["Reinai"] == i && coordinaten_blancas["Reinaj"] == j)
			{
				return true;
			}
            //Peones
			if(coordinaten_blancas["Peon1i"] == i && coordinaten_blancas["Peon1j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon2i"] == i && coordinaten_blancas["Peon2j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon3i"] == i && coordinaten_blancas["Peon3j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon4i"] == i && coordinaten_blancas["Peon4j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon5i"] == i && coordinaten_blancas["Peon5j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon6i"] == i && coordinaten_blancas["Peon6j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon7i"] == i && coordinaten_blancas["Peon7j"] == j)
			{
				return true;
			}
			if(coordinaten_blancas["Peon8i"] == i && coordinaten_blancas["Peon8j"] == j)
			{
				return true;
			}

			return false;
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
                {"TorreDi",0},{"TorreDj",7},
				{"Peon1i",1},{"Peon1j",0},
				{"Peon2i",1},{"Peon2j",1},
				{"Peon3i",1},{"Peon3j",2},
				{"Peon4i",1},{"Peon4j",3},
				{"Peon5i",1},{"Peon5j",4},
				{"Peon6i",1},{"Peon6j",5},
				{"Peon7i",1},{"Peon7j",6},
				{"Peon8i",1},{"Peon8j",7}
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
	
		public bool soyNegra(int i, int j)
		{
			if(coordinaten_negras["TorreIi"] == i && coordinaten_negras["TorreIj"] == j)
			{
				return true;
            }
			if(coordinaten_negras["ArfilBi"] == i && coordinaten_negras["ArfilBj"] == j)
			{
				return true;
            }
			if(coordinaten_negras["Caballo1i"] == i && coordinaten_negras["Caballo1j"] == j)
			{
				return true;
            }
			if(coordinaten_negras["ArfilNi"] == i && coordinaten_negras["ArfilNj"] == j)
			{
				return true;
            }
			if(coordinaten_negras["TorreDi"] == i && coordinaten_negras["TorreDj"] == j)
			{
				return true;
            }
			if(coordinaten_negras["Caballo2i"] == i && coordinaten_negras["Caballo2j"] == j)
			{
				return true;
            }
			if(coordinaten_negras["Reyi"] == i && coordinaten_negras["Reyj"] == j)
			{
				return true;
            }
			if(coordinaten_negras["Reinai"] == i && coordinaten_negras["Reinaj"] == j)
			{
				return true;
			}
            //Peones
			if(coordinaten_negras["Peon1i"] == i && coordinaten_negras["Peon1j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon2i"] == i && coordinaten_negras["Peon2j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon3i"] == i && coordinaten_negras["Peon3j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon4i"] == i && coordinaten_negras["Peon4j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon5i"] == i && coordinaten_negras["Peon5j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon6i"] == i && coordinaten_negras["Peon6j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon7i"] == i && coordinaten_negras["Peon7j"] == j)
			{
				return true;
			}
			if(coordinaten_negras["Peon8i"] == i && coordinaten_negras["Peon8j"] == j)
			{
				return true;
			}

			return false;
			
        }


	}

}
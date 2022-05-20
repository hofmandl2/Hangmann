using System;
using System.Drawing;
using System.Threading.Tasks;
    
class Ahorcado
{
  static void Main(string[] args)
  {
    //llamar a las otras clases
   
    Logic logic = new Logic();
    logic.start();
    
  }
  class Logic 
  {
    Draw draw = new Draw();

    List<string> palabras_dadas = new List<string>();
    string palabra_input; 
    char letra;
    char[] palabra_char;
    char[] palabra_vacia;
    bool complet = false; //Estar en falso si la palabra no ha sido completada
    bool find = false;
    bool lose = false; //Mira si el jugador perdio
    int trie = 0;
    public void start()
    { 
        Console.WriteLine("\nPalabras");
        while(true)
        {
            Console.Write("Escriba: ");
            palabra_input = Console.ReadLine().ToLower();
            if(palabra_input == "q")
            {
                break;
            }else {palabras_dadas.Add(palabra_input); }
        }
        //Se guarda la palabra escogida en la variable string
        palabra_input = palabras_dadas[random_numer()];//el metodo random_numer esta casi al final y da un numero aleatorio para que elija entre todos las palabras con el index
        //se crea el largo de los arreglos
        palabra_char = new char[palabra_input.Length];
        palabra_vacia = new char[palabra_input.Length];

        //relleno del arreglo con la palabra letra por letra para poder buscar
        for(int i = 0; i < palabra_input.Length; i++) 
        {
            palabra_char[i] = Convert.ToChar(palabra_input.Substring(i,1));                
        }
        //relleno del arreglo vacio para ver el progreso del juego
        for(int i = 0; i < palabra_vacia.Length; i++)
        {
            palabra_vacia[i] = '-';                
        }
        //Empieza el juego
        while(lose != true && complet !=  true)
        {
            
            Console.WriteLine("Escriba una letra: ");
            try //Try catch para que no se caiga por accidente si el usuario tipea mas de una letra 
            {
                letra = Convert.ToChar(Console.ReadLine());    
            }catch
            { 
                Console.WriteLine("Tiene que escribir una Letra, no un numero ni una palabra");
                Console.WriteLine("\nEscriba una letra: ");
                letra = Convert.ToChar(Console.ReadLine());
            }
            /*Recorre y mira si la letra esta, y la remplaza en la lista vacia*/
            for(int i = 0; i < palabra_char.Length; i++) 
            {
                if(letra == palabra_char[i])
                {
                    palabra_vacia[i] = palabra_char[i];
                    find = true;
                }
            }
            
            impress_charvacio();//imprime el char vacio, progreso del jugador
            
            //Foreach que mira si la lista vacia ya fue rellenada, y si es asi terminar el juego
            foreach(char c in palabra_vacia)
            {
                if (c == '-')
                {
                    complet = false;
                    break;
                }
                else
                {
                    complet = true;
                }
            }
            //Aca se mirar automaticamente si el juegador ha perdido un Intento o el Juego
            if(find != true)
            {
                
                switch(trie)
                {
                    //la clase draw esta al final y es la que dibuja todas las partes del cuerpo
                    case 0:
                        Console.WriteLine(draw.head());
                        trie++;
                        break;
                    case 1:
                        Console.WriteLine(draw.head());
                        Console.WriteLine(draw.necks_body());
                        trie++;
                        break;
                    case 2:
                        Console.WriteLine(draw.head());
                        Console.WriteLine(draw.arms());
                        trie++;
                        break;
                    case 3:
                        Console.WriteLine(draw.head());
                        Console.WriteLine(draw.arms());
                        Console.WriteLine(draw.legs());
                        trie++;
                        lose = true;
                        Console.WriteLine("Perdiste!");
                        break;
                    default:
                        break;
                }
                
            }
            find = false; //se coloca al final para que en la siguiente iteracion la variable no quede true
            
        }
        
        if(complet == true)
        {
            Console.WriteLine("Felicidades Ganaste!");
        }
        
    }
    
    void impress_charvacio()//imprime el array vacio
    {
        
        foreach(char i in palabra_vacia)
        {
            Console.Write(i);
        }
        Console.WriteLine(); 
    }
      
    private int random_numer() //nos da un numero aletariorio con Count que es el largo de la lista
    {
        Random random = new Random();
        int i = random.Next(palabras_dadas.Count());
        return i;
    }
  }
  class Draw
  { 
    public string head()
    {
            return(
          "  ___\n"+
          " |   |\n"+
          " |   |\n"+
          " |___|\n"
          );
    }
    public string necks_body()
    {
      return(

          "   |\n"+
          "   |\n"+
          "   |\n"+
          "   |\n"+
          "   |\n"+
          "   |\n"
      );
    }

    public string arms()
    {
      return(
          "    _____________\n"+
          "   |             |\n"+
          "   |             |\n"+
          "  /|\\            |\n"+
          " / | \\           |\n"+
          "/  |  \\          |\n"+
          "   |             |\n"+
          "   |             |\n"
            );
    }
    public string legs()
    {
      return(
      
           "  / \\            |\n"+
           " /   \\           |\n"+
           "/     \\         _|_\n");
    }
  }
}

using System;
using System.Drawing;
using System.Threading.Tasks;
    
class Ahorcado
{
  static void Main(string[] args)
  {
    //llamar a las otras clases
    Logic logic = new Logic();
  }
  class Logic 
  {
    List<string> wort_input = new List<string>(); //lista para guardas las palabras
    string[] palabras_array = new string[]{}; //array que tendra las palabras
    string palabra; //entrada de la palabra
    char[] palabra_adivinar; //la palabra escogida en tipo char
    char caracter;
    bool find = false; //si el caracter se encontro
    bool complet = false; //si la palabra ya esta completa
    public Logic()
    {
      Console.WriteLine("Geben Sie bitte Worte ab, damit das Spiel anfagen kann");
      while (true)
      {
        Console.Write("Wort: ");
        palabra = Console.ReadLine();
        if (palabra == "q"){break;} //Si es q salir
        else{wort_input.Add(palabra);} //de lo contrario entrar en la list
      }
        
      palabras_array = wort_input.ToArray(); //se convierte la lista en un array
      string choosed_wort = palabras_array[random_num_generation()]; //Se guarda la palabra aleatoria en una variable para convertirla en char
      palabra_adivinar = choosed_wort.ToCharArray(); //se convierte la palabra en un array tipo char
      char[] lista_vacia = new char[palabra_adivinar.Length]; //lista que se imprimira vacia y se llenara

      for (int i = 0; i < palabra_adivinar.Length;i++) //rellena la lista que el usario vera
      {
        lista_vacia[i] = '_';
      }
      /*foreach(char i in palabra_adivinar)
      {
        Console.Write(i+" ");
      }
      Console.WriteLine(" ");*/
      while (complet != true)
      {
        foreach (char i in lista_vacia)
        {
          
          Console.Write(i+" ");

        }
        Console.WriteLine("\nGeben Sie ein Buschatabe: "); //letra dada 
        caracter = char.Parse(Console.ReadLine());
        Console.WriteLine();

        for(int i = 0 ; i< palabra_adivinar.Length; i++) //for que vera si la letra dada esta en la lista
        {
          Console.WriteLine();
          if (caracter == palabra_adivinar[i])
          {
            Console.WriteLine("Richtig! ");
            lista_vacia[i] = caracter;
            find = true;
          }
          else{//tries++;
          }
        }

        foreach(char a in lista_vacia) //Observa si la palabra ya se completo
        {
          if(a != '_')
          {
            complet =true;
          }else{complet=false;
          break;}
        }
        if (find != true)
        {
          //draw
        }
        
        find = false;
      }
      Console.Write("\nFuera de while");
      //Termino el Juego
      
      
      void getArray()
      {
        Console.WriteLine(String.Join("\n", palabras_array));
      }
      int random_num_generation()
      {
        Random random = new Random();
        int i = random.Next(palabras_array.Length);
        return i;
      }
    }
  }
}
  

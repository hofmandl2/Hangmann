﻿using System;
using System.Drawing;
using System.Threading.Tasks;
    
class Ahorcado
{
  static void Main(string[] args)
  {
    //llamar a las otras clases
    Console.ReadKey();
    Logic logic = new Logic();
    logic.start();
    
  }
  class Logic 
  {
    List<string> wort_input = new List<string>(); //lista para guardas las palabras
    string[] palabras_array = new string[]{}; //array que tendra las palabras
    string palabra = " "; //entrada de la palabra
    char[] palabra_adivinar; //la palabra escogida en tipo char
    char caracter =  ' ';
    bool find = false; //si el caracter se encontro
    public bool complet; //si la palabra ya esta completa
    Draw draw = new Draw(); //llamada a la clase que dibujara el cuerpo
    public void start()
    {
      Console.WriteLine("Geben Sie bitte Worte ab, damit das Spiel anfagen kann");
      while (complet == false)
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
      
      while (complet == false)
      {
        Console.WriteLine("\n");
        foreach (char i in lista_vacia)//lista que imprira al usario su progreso
        {
          
          Console.Write(i+" ");

        }

        Console.WriteLine("\nGeben Sie ein Buschatabe: "); //letra dada 
        caracter = char.Parse(Console.ReadLine());
        Console.WriteLine();

        for(int i = 0 ; i< palabra_adivinar.Length; i++) //for que vera si la letra dada esta en la lista
        {
          if (caracter == palabra_adivinar[i])
          {
            Console.WriteLine("Richtig!");
            lista_vacia[i] = caracter;
            find = true;
          }
        }

        foreach(char a in lista_vacia) //Observa si la palabra ya se completo
        {
          if(a != '_')
          {
            setComplet(true);
          }else{setComplet(false);
          break;}
        }
        if (find != true)
        {
          draw.drawCase(draw.getTries());
          draw.tries++;
        }
        find = false;
      }
      Console.Write("\nFuera de while");
      //Termino el Juego
      
      int random_num_generation()
      {
        Random random = new Random();
        int i = random.Next(palabras_array.Length);
        return i;
      }
    }
    public void restart()
    {
      //Borrar el array de palabras
      for(int i = 0; i<palabras_array.Length; i++)
      {
        //Borrar todo el contenido
      }
    }
    public void setComplet(bool complet)
    {
      this.complet = complet;
    }
  }
  class Draw
  {   
    public int tries  = 0;
    string nochmal;
    Logic logic = new Logic();
    public void drawCase(int triesC)
    {
      switch (triesC)
      {
        case 0:
          Console.Write(head());
          break; 
        case 1:
          Console.Write(head());
          Console.Write(necks_body());
          break;
        case 2 :
          Console.Write(head());
          Console.Write(arms());
          break;
        case 3:
          Console.Write(head());
          Console.Write(arms());
          Console.Write(legs());
          Console.WriteLine("Verloren \n"+"\n Wollen Sie nochmal spielen?");
          nochmal = Console.ReadLine();
          if(nochmal == "y")
          {
            logic.setComplet(false);
            tries = 0;
            logic.restart();
          }else{logic.setComplet(true);
          tries = 0;
          break;}

          break;
        default:
          Console.WriteLine("ops algo salio mal con el switch case");
          Console.Write(triesC);
          break;
      }
      logic.complet = false;
    }
    public int getTries()
    {
      return tries;
    }
    private string head()
    {
            return(
          "  ___\n"+
          " |   |\n"+
          " |   |\n"+
          " |___|\n"
          );
    }
    private string necks_body()
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

    private string arms()
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
    private string legs()
    {
      return(
      
           "  / \\            |\n"+
           " /   \\           |\n"+
           "/     \\         _|_\n");
    }
  }
}
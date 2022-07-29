namespace Nuevo {
    class Board {
        private readonly Pieza?[,] tablero = new Pieza?[8, 8];

        public Board() {
            tablero[0, 1] = new Torre(ConsoleColor.Yellow);
            tablero[5, 5] = new Torre(ConsoleColor.Black);
        }

        public Pieza? get_pieza(Position position) {
            return tablero[position.numero, position.letra];
        }

        public void move(Pieza pieza, Move move) {
            if (tablero[move.origen.numero, move.origen.letra] == null) {
                throw new Exception("No piece to move!!");
            }
            tablero[move.origen.numero, move.origen.letra] = null;

            Pieza? targetPiece = tablero[move.destino.numero, move.destino.letra];
            if(targetPiece != null)
            {
                Console.WriteLine("Killed another piece: " + pieza);
            }
            tablero[move.destino.numero, move.destino.letra] = pieza;
        }

        public void draw() {
            for (int numero=0; numero<8; ++numero) {
                Console.Write(numero);
                for (int letra=0; letra<8; ++letra) {
                    Pieza? pieza = get_pieza(new Position(numero, letra));

                    ConsoleColor background = (letra % 2 == 0 && numero % 2 == 0 || letra % 2 != 0 && numero % 2 != 0) ? ConsoleColor.Green : ConsoleColor.DarkGreen;
                    Console.BackgroundColor = background;
                    if (pieza == null) {
                        Console.ForegroundColor = background;
                        Console.Write("   ");
                    } else {
                        pieza.draw();
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Write(" ");
            for (char c = 'A'; c <= 'H'; c++)
            {
                Console.Write(" " + c + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Nuevo {

    public class ExitException : Exception {
        public ExitException(string message) : base(message) {

        }
    }

    public class nuevo_main {
        public static void Main(string[] arg) {
            try {
                Board board = new Board();
                board.draw();

                while (true) {
                    Move move = Move.inputMove();
                    Pieza? pieza = board.get_pieza(move.origen);
                    if (pieza == null) {
                        Console.WriteLine("There is no piece at the origin!!!");
                        continue;
                    }
                    pieza.move(move, board);

                    board.draw();
                }
            } catch (ExitException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

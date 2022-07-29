namespace Nuevo {
    abstract class Pieza {
        private ConsoleColor color;
        public Pieza (ConsoleColor color) {
            this.color = color;
        }
        public ConsoleColor getColor() {
            return this.color;
        }

        public abstract void draw();

        public abstract void move(Move move, Board board);
    }

    class Torre : Pieza {
        public Torre(ConsoleColor color) : base(color) {
            
        }
        public override void draw() {
            Console.ForegroundColor = this.getColor();
            Console.Write(" ♖ ");
        }
        public override void move(Move move, Board board) {
            board.move(this, move);
        }
    }

    // demas piezas
}
namespace Nuevo {
    class Move {
        public readonly Position origen;
        public readonly Position destino;

        private Move (Position origen, Position destino) {
            if (origen == destino) {
                throw new ArgumentException("origen must be diferent from destino");
            }
            this.origen = origen;
            this.destino = destino;
        }

        public static Move inputMove() {
            Position origin = Position.inputPos("Please enter position of piece you want to move");
            Position destination = Position.inputPos("Please enter position where you want to move the piece");
            return new Move(origin, destination);
        }
    }
}
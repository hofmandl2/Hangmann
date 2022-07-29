namespace Nuevo {

    class Position {
        public readonly int numero;
        public readonly int letra;

        public Position(int numero, int letra) {
            if (numero < 0 || numero > 7) {
                throw new ArgumentOutOfRangeException("y must be between 0 and 7");
            }
            if (letra < 0 || letra > 7) {
                throw new ArgumentOutOfRangeException("x must be between 0 and 7");
            }
            this.numero = numero;
            this.letra = letra;
        }

        public static Position inputPos(String message) {
            while (true) {
                Console.Write(message);
                string input = Console.ReadLine(); // A1
                if(input == "q")
                {
                    throw new ExitException("Good bye.");
                }
                try {
                    return Position.fromInput(input);
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        private static Position fromInput(string input) {
            if (input.Length != 2) {
                throw new Exception("You must provide exactly two characters, e.g. C2");
            }
            char letra = input[0];
            if (letra < 65 || letra > 73) {
                throw new Exception("First character must be a letter between A and H");
            }
            int numero = int.Parse(input.Substring(1,1));
            if (numero < 0 || numero > 7) {
                throw new Exception("Second character must be a number between 0 and 7");
            }
            return new Position(numero, letra - 65);
        }
    }
}
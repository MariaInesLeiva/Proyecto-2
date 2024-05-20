using Proyecto_2;
class Program
{
    static void Main(string[] args)
    {
        Tablero tablero = new Tablero(); //Se creo el objeto de la clase tablero
        Pieza pieza= new Pieza(); // Se creo el objeto de la clase pieza
        
        int opcion = '0'; // Se declaró la variable opcion como int para realizar el menú
    


        while (opcion != '5') //Se creo un bucle de while para poder realizar el switch
        {
            Console.WriteLine("");
            Console.WriteLine(" ♟️ Juego de ajedrez♟️");
            Console.WriteLine("Siga las instrucciones en el orden correspondiente");
            Console.WriteLine("1) Agregar las piezas ♘ ♜ ♙"); //Se crearon las instrucciones para buscar los posibles movimientos
            Console.WriteLine("2) Agregar la dama ♛");
            Console.WriteLine("3) Mostrar los posibles movimientos ↔️  ↕️  ↗  ↙");
            Console.WriteLine("4) Imprimir tablero 🔲");
            Console.WriteLine("5) Salir del juego 🏃‍♀️");

            opcion = Console.ReadLine()[0];
            
            int opcionNum = int.Parse(opcion.ToString());

            switch (opcionNum)
            {
                case '1':
                    Console.WriteLine("¿Cuántas piezas desea agregar?");
                    int CantidadPieza= int.Parse(Console.ReadLine()); 
                    tablero.GuardarTablero(CantidadPieza); //Se mandó a llamar a la función guardar tablero, que contiene la información de las piezas
                    break;
                case '2':
                    tablero.GuardarDama(); //Se mandó a llamar a la función guardar dama, que contiene la información de la dama
                    break;
                case '3':
                    tablero.Movimientos(); //Se mandó a llamar a la función movimientos, que contiene la información de los movimientos del tablero
                    break;
                case '4':
                    tablero.MostrarTablero(); //Se mandó a llamar a la función mostrar tablero, que contiene la información del tablero
                    break;
                case '5': //Se creó esta opción para poder salir del juego
                    break;
                
                default: //Se creo un default para verificar que se ingrese la opción indicada
                Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
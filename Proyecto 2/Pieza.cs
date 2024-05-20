namespace Proyecto_2;

public class Pieza
{
    public int cantidadPieza; // Se declaró la variable cantidadPieza
    public string colorPieza; // Se declaró la variable colorPieza
    public string tipoPieza; // Se declaró la variable tipoPieza
    public string posicionPieza; // Se declaró la variable posicionPieza
    public int Filas; // Se declaró la variable Filas
    public int Columna; // Se declaró la variable Columnas

    public Pieza() //Se creo una función para declara los valores que contienen la información de la pieza
    {
        colorPieza = ""; //La variables se asignaron con valores vacíos para poder aceptar la información que ingrese el usuario
        tipoPieza = "";
        posicionPieza = "";
    }

    public void TipoPieza() //Se creo una función para solicitar la información del tipo pieza
    {
        Tablero objtablero = new Tablero(); //Se creo el objeto tablero
        Console.WriteLine("¿Tipo de pieza que desea agregar? " + "(alfil, peon, torre, caballo)");
        tipoPieza = Console.ReadLine(); //Se guarda la información en el tipo pieza
    
        do //Se utilizó un ciclo do while para validar los colores blanco y negro; de otra manera no acepta el color ingresado
        {
            Console.WriteLine("¿Tipo de color para el/la " + tipoPieza + "? " + "(blanco o negro)");
            colorPieza = Console.ReadLine(); // Se guarda el color ingresado en la variable
            if (colorPieza == "blanco" || colorPieza == "negro") // Se utiliza la condición if para validar que el color sea adecuado y el código pueda continuar
            {
                break; //Se termina el ciclo
            }
            if (colorPieza != "blanco" && colorPieza != "negro") //Se utiliza la condición if para mostrar un mensaje de color inválido si se ingresa un color no aceptado
            {
                Console.WriteLine("Color inválido");
            }

        } while (true); //Indica que el ciclo se repetirá hasta que se ingrese el color adecuado

        Console.WriteLine("¿Posición para el/la " + tipoPieza + "?");
        posicionPieza = Console.ReadLine(); //Se guarda la posición de pieza ingresada

        for (int x = 0; x < objtablero.tablero.GetLength(0); x++) //Se recorren las filas de la matriz para encontrar la posición
        {
            for (int j = 0; j < objtablero.tablero.GetLength(1); j++) //Se recorren las columnas de la matriz para encontrar la posición
            {
                if (posicionPieza == objtablero.tablero[x, j]) //Se utilizó la condición para verificar que la condición que se ingresó tiene relación con el tablero
                {
                    Filas = x; // Se asignaron los valores para las variabled filas y columnas
                    Columna = j;
                }
            }
        }

    }

    public void Dama() //Se creo la función dama donde se almacenará la información de la dama
    {
        Tablero objtablero = new Tablero(); //Se creo el objeto tablero
        tipoPieza = "dama"; //Se asignó el un valor específico a la variable tipoPieza, ya que, solo es para la dama
        
        do //Se creo un ciclo do while para verificar el color de la dama
        {
            Console.WriteLine("¿Tipo de color de la dama?" + "(blanco o negro)");
            colorPieza = Console.ReadLine(); //El color escogido se guardrá en la variable colorPieza
            if (colorPieza == "blanco" || colorPieza == "negro") //Se utiliza la condición if para validar que el color sea adecuado y el código pueda continuar
            {
                break; //Se termina el ciclo
            }
            if (colorPieza != "blanco" && colorPieza != "negro") //Se utiliza la condición if para mostrar un mensaje de color inválido si se ingresa un color no aceptado
            {
                Console.WriteLine("Color inválido");
            }

        } 
        while (true); //Indica que el ciclo se repetirá hasta que se ingrese el color adecuado

        Console.WriteLine("¿Posición de la dama?");
        posicionPieza = Console.ReadLine(); //Se guardará la posición ingresada en la variable posicionPieza

        for (int i = 0; i < objtablero.tablero.GetLength(0); i++) //Se recorren las filas de la matriz para encontrar la posición
        {
            for (int j = 0; j < objtablero.tablero.GetLength(1); j++) //Se recorren las columnas de la matriz para encontrar la posición
            {
                if (posicionPieza == objtablero.tablero[i, j]) //Se utilizó la condición para verificar que la condición que se ingresó tiene relación con el tablero
                {
                    Filas = i; // Se asignaron los valores para las variabled filas y columnas
                    Columna = j;
                }
            }

        }
    }
}

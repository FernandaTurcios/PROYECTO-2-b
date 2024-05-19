using PROYECTO_2_B;

public class Program 
{
    public static void Main()
    {
        string [,] tablero = new string[8, 8]; //Crear matriz

        for (int fila = 0; fila < 8; fila++) //Recorrer matriz
        {
            for (int columna = 0; columna < 8; columna ++)
            {
                tablero [fila, columna] = "-";
            }
        }

        //Asignar la notación al tablero
        tablero [0, 0] = "a8";
        tablero [0, 1] = "b8";
        tablero [0, 2] = "c8";
        tablero [0, 3] = "d8";
        tablero [0, 4] = "e8";
        tablero [0, 5] = "f8";
        tablero [0, 6] = "g8";
        tablero [0, 7] = "h8";

        tablero [1, 0] = "a7";
        tablero [1, 1] = "b7";
        tablero [1, 2] = "c7";
        tablero [1, 3] = "d7";
        tablero [1, 4] = "e7";
        tablero [1, 5] = "f7";
        tablero [1, 6] = "g7";
        tablero [1, 7] = "h7";

        tablero [2, 0] = "a6";
        tablero [2, 1] = "b6";
        tablero [2, 2] = "c6";
        tablero [2, 3] = "d6";
        tablero [2, 4] = "e6";
        tablero [2, 5] = "f6";
        tablero [2, 6] = "g6";
        tablero [2, 7] = "h6";

        tablero [3, 0] = "a5";
        tablero [3, 1] = "b5";
        tablero [3, 2] = "c5";
        tablero [3, 3] = "d5";
        tablero [3, 4] = "e5";
        tablero [3, 5] = "f5";
        tablero [3, 6] = "g5";
        tablero [3, 7] = "h5";

        tablero [4, 0] = "a4";
        tablero [4, 1] = "b4";
        tablero [4, 2] = "c4";
        tablero [4, 3] = "d4";
        tablero [4, 4] = "e4";
        tablero [4, 5] = "f4";
        tablero [4, 6] = "g4";
        tablero [4, 7] = "h4";

        tablero [5, 0] = "a3";
        tablero [5, 1] = "b3";
        tablero [5, 2] = "c3";
        tablero [5, 3] = "d3";
        tablero [5, 4] = "e3";
        tablero [5, 5] = "f3";
        tablero [5, 6] = "g3";
        tablero [5, 7] = "h3";

        tablero [6, 0] = "a2";
        tablero [6, 1] = "b2";
        tablero [6, 2] = "c2";
        tablero [6, 3] = "d2";
        tablero [6, 4] = "e2";
        tablero [6, 5] = "f2";
        tablero [6, 6] = "g2";
        tablero [6, 7] = "h2";

        tablero [7, 0] = "a1";
        tablero [7, 1] = "b1";
        tablero [7, 2] = "c1";
        tablero [7, 3] = "d1";
        tablero [7, 4] = "e1";
        tablero [7, 5] = "f1";
        tablero [7, 6] = "g1";
        tablero [7, 7] = "h1";
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("¡Bienvenido! ♟️😃");
        Console.WriteLine("");
        Console.WriteLine("El tablero es el siguiente:"); //Mostrar el tablero con la notación de las posiciones
        //Imprimir tablero
        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna  < 8; columna++)
            {
                Console.Write(tablero[fila,columna] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Tablero objTablero = new Tablero(); //Se creó un objeto de la clase tablero
        Console.WriteLine("INGRESE LOS DATOS DE LAS PIEZAS");
        Console.WriteLine("");
        objTablero.GuardarPosiciones(); //Se llamó a la función GuardarPosiciones de la clase Tablero
        Console.WriteLine("");
        Console.WriteLine("INGRESE LOS DATOS DE LA DAMA A EVALUAR");
        objTablero.GuardarPosicionDama(); //Se llamó a la función GuardarPosicionDama de la clase Tablero
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("LAS POSICIONES DISPONIBLES ✅ SON:");
        Console.WriteLine("P = peón; C = caballo; T = torre; A = alfil; R = rey");
        objTablero.Vertical(); //Se llamó a la función Vertical de la clase Tablero
        objTablero.Horizontal(); //Se llamó a la función Horizontal de la clase Tablero
        objTablero.DiagonalPositiva1(); //Se llamó a la función DiagonalPositiva1 de la clase Tablero
        objTablero.DiagonalPositiva2(); //Se llamó a la función DiagonalPositiva2 de la clase Tablero
        objTablero.DiagonalNegativa1(); //Se llamó a la función DiagonalNegativa1 de la clase Tablero
        objTablero.DiagonalNegativa2(); //Se llamó a la función DiagonalNegativa2 de la clase Tablero
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("                      ♟️  TABLERO ♟️ ");
        Console.WriteLine("P = peón; C = caballo; T = torre; A = alfil; R = rey");
        Console.WriteLine("");
        objTablero.ImprimirMatriz(); //Se llamó a la función ImprimirMatriz de la clase Tablero
    }
}


using System.Security.Cryptography.X509Certificates;

namespace PROYECTO_2_B;

public class Tablero
{
    public Pieza[,] board; //Se declaró una matriz de la clase pieza
    int fila; //Se declaró la variable fila
    int columna; //Se declaró la variable columna
    public Tablero () //Se creo un constructor de la clase Tablero
    {
        board = new Pieza [8, 8]; // Se inicializó la matriz board
        tablero [0, 0] = "a8"; // Se inicializaron las posiciones de la matriz tablero
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
    }
    string [,] tablero = new string[8, 8]; //Crear matriz

    public void GuardarPosiciones () // Se creo una función para guardar las posiciones de las piezas ingresadas
    {
        Console.WriteLine("¿Cuántas piezas desea ingresar?"); // Se solicitó la cantidad de piezas que se desea ingresar
        int numDePiezas = int.Parse(Console.ReadLine());  // Se declaró e inicializó la variable numDePiezas
        while (numDePiezas > 0) //Se utilizó un bucle para repetir la acción mientras que la cantidad de piezas sea mayor a 0
        {
        Pieza objPieza = new Pieza(); //Se creó un objeto de la clase Pieza
        objPieza.InfoPiezas(); //Se llamó a la función InfoPiezas de la clase Pieza
        for (int i = 0; i<8; i++) // Se utilizó un ciclo for para recorrer la matriz y guardar las posiciones 
        {
            for (int j = 0; j < 8; j++)
            {
                if (tablero[i,j] == objPieza.posicionDePieza)
                {
                    fila = i;
                    columna = j;
                }
            }
        }
        if (board [fila, columna] == null) //Se utilizó un if para verificar si la posición de la matriz board está vacía
        {
            board [fila, columna] = objPieza;
        }
        else 
        {
            Console.WriteLine("Esta casilla está ocupada"); 
        }

            numDePiezas--; // Se utilizó un decremento a la variable numDePiezas
        }
    }

    public void GuardarPosicionDama () // Se creo la función GuardarPosicionDama para guardar las posiciones de la dama a evaluar
    {

        Pieza objPieza = new Pieza(); // Se creo un objeto de la clase Pieza
        objPieza.InfoDama();
        for (int i = 0; i<8; i++) // Se recorrió la matriz para guardar la posición de la dama a evaluar
        {
            for (int j = 0; j < 8; j++)
            {
                if (tablero[i,j] == objPieza.posicionDeDama)
                {
                    fila = i;
                    columna = j;
                }
            }
        }
        if (board [fila, columna] == null) //Se utilizó un if para evaluar si la casilla está vacía 
        {
            board [fila, columna] = objPieza;
        }
        else 
        {
            Console.WriteLine("Esta casilla está ocupada");
        }

    }

    public void Vertical () // Se creo una función para evaluar los movimientos verticales de la dama
    {
        for (int filaA = fila-1; filaA >= 0; filaA--) //Se utilizó un for para recorrer la matriz decrementando la variable fila 
        {
            if (board[filaA, columna] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[filaA, columna]+ ", está vacía"); //Si no está siendo ocupada, es "nula", se mostrará un mensaje de que está vacía
            }
            else 
            {
                if (board[filaA, columna].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[filaA, columna]+ ", contiene "+ board[filaA, columna].tipoDePieza); //Si está siendo ocupada por una pieza de distinto color se mostrará que tipo pieza contiene
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        for (int filaA = fila+1; filaA < 8; filaA++) //Se utilizó un for para recorrer la matriz incrementando la variable fila 
        {
            if (board[filaA, columna] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[filaA, columna]+ ", está vacía"); //Si no está siendo ocupada, es "nula", se mostrará un mensaje de que está vacía
            }
            else 
            {
                if (board[filaA, columna].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[filaA, columna]+ ", contiene "+ board[filaA, columna].tipoDePieza); //Si está siendo ocupada por una pieza de distinto color se mostrará que tipo pieza contiene
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
    
    public void Horizontal () // Se creo una función para evaluar los movimientos horizontales de la dama
    {
        for (int columnaA = columna-1; columnaA >= 0; columnaA--) //Se utilizó un for para recorrer la matriz decrementando la variable columnaA 
        {
            if (board[fila, columnaA] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[fila, columnaA]+ ", está vacía"); //Si no está siendo ocupada, es "nula", se mostrará un mensaje de que está vacía
            }
            else 
            {
                if (board[fila, columnaA].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[fila, columnaA]+ ", contiene "+ board[fila, columnaA].tipoDePieza);  //Si está siendo ocupada por una pieza de distinto color se mostrará que tipo pieza contiene
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        for (int columnaA = columna+1; columnaA < 8; columnaA++) //Se utilizó un for para recorrer la matriz incremento la variable columnaA 
        {
            if (board[fila, columnaA] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[fila, columnaA]+ ", está vacía"); //Si no está siendo ocupada, es "nula", se mostrará un mensaje de que está vacía
            }
            else 
            {
                if (board[fila, columnaA].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[fila, columnaA]+ ", contiene "+ board[fila, columnaA].tipoDePieza); //Si está siendo ocupada por una pieza de distinto color se mostrará que tipo pieza contiene
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }

    public void DiagonalPositiva1 () // Se creo una función para evaluar los movimientos en diagonal hacia arriba y hacia la derecha
    {
        int filaA= fila; //Se igualó la variable filaA a la variable fila
        int columnaA = columna; //Se igualó la variable columnaA a la variable columna
        if (filaA != 0 && columnaA != 7) // Se utilizó un if para evaluar los parámetros en los que se encuentra la dama
        {
        do // Se utilizó un ciclo do while para ejecutar el bloque por lo menos una vez hasta no cumplir la restricción  
        {
            filaA --; // Se realizó un decremento a la variable filaA
            columnaA ++; // Se realizó un incremento a la variable columnaA
            if (board[filaA, columnaA] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[filaA, columnaA]+ ", está vacía");
            }
            else 
            {
                if (board[filaA, columnaA].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[filaA, columnaA]+ ", contiene "+ board[filaA, columnaA].tipoDePieza);
                    break;
                }
                else
                {
                    break;
                }
            }
        }while (filaA > 0 && columnaA < 7); //Se realizó la restricción del ciclo do while
        }
    }

    public void DiagonalPositiva2 () // Se creo una función para evaluar los movimientos en diagonal hacia abajo y hacia la izquierda
    {
        int filaA= fila; 
        int columnaA = columna;
        if (filaA != 7 && columnaA != 0)
        {
        do 
        {
            filaA ++; // Se realizó un incremento a la variable filaA
            columnaA --; // Se realizó un decremento a la variable columnaA
            if (board[filaA, columnaA] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[filaA, columnaA]+ ", está vacía");
            }
            else 
            {
                if (board[filaA, columnaA].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[filaA, columnaA]+ ", contiene "+ board[filaA, columnaA].tipoDePieza);
                    break;
                }
                else
                {
                    break;
                }
            }
        }while (filaA < 7 && columnaA > 0); //Se realizó la restricción del ciclo do while
        }
    }

    public void DiagonalNegativa1 () // Se creo una función para evaluar los movimientos en diagonal hacia arriba y hacia la izquierda
    {
        int filaD= fila; //Se igualó la variable filaD a la variable fila
        int columnaD = columna; //Se igualó la variable columnaD a la variable columna
        if (filaD != 0 && columnaD != 0) // Se utilizó un if para evaluar los parámetros en los que se encuentra la dama
        {
        do // Se utilizó un ciclo do while para ejecutar el bloque por lo menos una vez hasta no cumplir la restricción  
        {
            filaD --; // Se realizó un decremento a la variable filaD
            columnaD --; // Se realizó un decremento a la variable columnaD
            if (board[filaD, columnaD] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[filaD, columnaD]+ ", está vacía");
            }
            else 
            {
                if (board[filaD, columnaD].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[filaD, columnaD]+ ", contiene "+ board[filaD, columnaD].tipoDePieza);
                    break;
                }
                else
                {
                    break;
                }
            }
        }while (filaD >0 && columnaD > 0); //Se realizó la restricción del ciclo do while
        }
    }

    public void DiagonalNegativa2 () // Se creo una función para evaluar los movimientos en diagonal hacia abajo y hacia la derecha
    {
        int filaD= fila;
        int columnaD = columna;
        if (filaD != 7 && columnaD != 7)
        {
        do 
        {
            filaD ++; // Se realizó un incremento a la variable filaD
            columnaD ++; // Se realizó un incremento a la variable columnaD

            if (board[filaD, columnaD] == null) //Se utilizó un if para verificar si la casilla está siendo ocupada
            {
                Console.WriteLine(tablero[filaD, columnaD]+ ", está vacía");
            }
            else 
            {
                if (board[filaD, columnaD].colorDePieza != board[fila, columna].colorDeDama) // Se utilizó un if para evaluar que el color de la pieza sea distinto al color de la dama
                {
                    Console.WriteLine(tablero[filaD, columnaD]+ ", contiene "+ board[filaD, columnaD].tipoDePieza);
                    break;
                }
                else
                {
                    break;
                }
            }
        }while (filaD < 7 && columnaD < 7); //Se realizó la restricción del ciclo do while
        }
    }

    public void ImprimirMatriz () //Se creo una función para imprimir el trablero con las piezas y la dama ingresadas
    {
        for (int fila = 0; fila < 8;fila ++) //Se utilizó un ciclo for para recorrer la matriz en fila
        {
        for (int columna = 0; columna < 8; columna++) //Se utilizó un ciclo for para recorrer la matriz en columna
        {
            if (board[fila, columna] == null) //Se utilizó un if para mostrar "-" si la casilla está vacía
            {
                Pieza objPieza = new Pieza (); //Se creo un objeto de la clase Pieza
                objPieza.tipoDePieza = "-";
                objPieza.colorDePieza = " ";
                board[fila, columna] = objPieza;
            }
            Console.Write (board[fila, columna].tipoDePieza + board[fila, columna].emojiCOlor + "\t"); //Se imprime el tablero en cada posición utilizando tabulación
        }
        Console.WriteLine(" ");
        }
    }
}

namespace PROYECTO_2_B;

public class Pieza
{
    public string posicionDePieza; // Se declaró la variable posicionDePieza
    public string colorDePieza; // Se declaró la variable colorDePieza
    public string tipoDePieza; // Se declaró la variable tipoDePieza
    public string colorDeDama; // Se declaró la variable colorDeDama
    public string tipoDeDama; // Se declaró la variable tipoDeDama
    public string posicionDeDama; // Se declaró la variable posicionDeDama
    public string emojiCOlor;
    public void InfoPiezas()
    {
        Console.WriteLine("Ingrese el tipo de la pieza (peon, caballo, torre, alfil o rey):"); //Se pidió el tipo de pieza que desea ingresar el usuario
        tipoDePieza = Console.ReadLine(); //Se guardó el dato en la variable tipoDePieza
        switch (tipoDePieza) //Se utilizó un switch para igualar la variable a una literal que representa la pieza para mostrar en el tablero final
        {
            case "peon":
                tipoDePieza = "P";
                break;
            case "caballo":
                tipoDePieza = "C";
                break;
            case "torre":
                tipoDePieza = "T";
                break;
            case "alfil":
                tipoDePieza = "A";
                break;
            case "rey":
                tipoDePieza = "R";
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("Ingrese el color de la pieza (blanco o negro, sin importar género de la pieza):"); //Se solicitó el dato del color de la pieza que se ingresó
        colorDePieza = Console.ReadLine(); //Se guardó el dato en la variable colorDePieza
        switch (colorDePieza) //Se utilizó un switch para igualar la variable a un emoji para mostrar el color de la pieza en el tablero final
        {
            case "blanco":
                colorDePieza = "B";
                emojiCOlor = "🤍";
                break;
            case "negro":
                colorDePieza = "N";
                emojiCOlor = "🖤";
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("Ingrese la posición de la pieza (seguir la notación del tablero)"); //Se solicitó el dato de la posición de la pieza que se ingresó
        posicionDePieza = Console.ReadLine(); //Se guardó el dato en la variable posicionDePieza
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("");

    }

    public void InfoDama()
    {
        tipoDePieza = "D"; // Se inicializó la variable tipoDePieza
        tipoDeDama = "D"; // Se inicializó la variable tipoDeDama
        Console.WriteLine("");
        Console.WriteLine("Ingrese el color de la dama:"); //Se solicitó en color de la dama que se evaluará
        colorDeDama = Console.ReadLine(); // Se guardó el dato en la variable colorDeDama
        colorDePieza = colorDeDama; // Se igualó la variable colorDePieza a la variable colorDeDama
        switch (colorDePieza) //Se utilizó un switch para igualar la variable a un emoji para mostrar el color de la dama en el tablero final
        {
            case "blanco":
                colorDeDama = "B";//igualamos la dama a sus iniciales correspondientes
                colorDePieza = "B";
                emojiCOlor = "🤍";
                break;
            case "negro":
                colorDeDama = "N";
                colorDePieza = "N";
                emojiCOlor = "🖤";
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("Ingrese la posición de la dama"); // Se solicitó la posición de la dama
        posicionDeDama = Console.ReadLine(); // Se guardó el dato en la variable posicionDeDama
        Console.WriteLine("");
    }
}

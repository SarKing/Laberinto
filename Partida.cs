using System;
public class Partida : Pantalla{
    protected static readonly int WIDTH = 31;
    protected static readonly int HEIGHT = 15;
    protected static int origRow;
    protected static int origCol;

    public static void PrintCanvas(){
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        // Primera Fila
        for(int i = 0; i < WIDTH; i++){
            WriteAt("#", i, 0);
        }
        // Columanas derecha e izquierda
        for(int i = 1; i < HEIGHT-1; i++){
            WriteAt("#", 0, i);
            WriteAt("#", WIDTH-1, i);
        }
        // Ultima fila
        for (int i = 0; i < WIDTH; i++) {
            WriteAt("#", i, HEIGHT-1);
        }
    }

    protected static void WriteAt(string s, int x, int y) {
        try {
            Console.SetCursorPosition(origCol + x, origRow + y - 1);
            Console.Write(s);
        } catch (ArgumentOutOfRangeException e) {
            Console.Clear();
            Console.WriteLine(e.Message);
            
        }
    }
}
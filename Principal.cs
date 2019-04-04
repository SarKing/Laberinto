using System;

public class Principal{


    
    public static void Main(){
        
        Console.CursorVisible = true;
        

        Partida.PrintCanvas();
        Personaje pj = new Personaje(10,10,"x");
        
        while(true){
            // Main loop
            pj.Teclas();
            
        }
    }
}
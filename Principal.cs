using System;

public class Principal{


    
    public static void Main(){
        
        int initx = 14;
        int inity = 13; 


        Console.CursorVisible = true;
        

        Partida.PrintCanvas();
        Personaje pj = new Personaje(10,10,'x');
        pj.Transportar(ref initx,ref inity);

        Console.CursorVisible = false;
        while(true){
            // Main loop
            pj.Teclas();

            if(pj.win = true){
                // Iniciar los creditos
            }
        }
    }
}
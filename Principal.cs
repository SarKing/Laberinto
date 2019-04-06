using System;
using System.Timers;

/*
    Hacer que se tenga que pasar en un tiepo, y poner un power up que sea & que te de mas tiempo                        
    Hacer que no se puedan pulsar mas teclas en la pantalla de juego
    Hacer un timer de juego (Como los ticks en minecraft)
*/

public class Principal{

    static bool mover = false;

    public static void Main(){
        
        int initx = 14;
        int inity = 13; 

        Console.CursorVisible = true;

        Partida.PrintCanvas();
        Hero pj = new Hero('x','·', 3, 1);
        Enemigo en = new Enemigo('T', '-', 1, 1, 4, 8);
        pj.Transportar(ref initx,ref inity);

        Console.CursorVisible = false;

        // Creamos el timer
        Timer aTimer = new Timer();

        aTimer.Interval = 500;

        aTimer.Elapsed += MoverAlEnemigo;

        aTimer.Enabled = true;

        while(true){
            // Main loop
            // Mientras no se pulse ninguan letra
            while (!Console.KeyAvailable) {
                if(mover == true){
                    mover = false;
                    en.Movimiento();
                }
                
            }
            // De aqui para abajo es si se ha pulsado una tecla
            pj.Teclas();
            
/*             if(pj.win == true){
                // Iniciar los creditos
                Bienvenida.Inicio();
            } */
        }
    }

    public static void MoverAlEnemigo(Object source, ElapsedEventArgs e){
        Partida.PrintCanvas();
        mover = !mover;
    }
}
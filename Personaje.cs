using System;

public class Personaje{
    public int x = 0;
    public int y = 0;
    public char skin;
    public bool win = false;


    public Personaje(int x, int y, char skin){
        this.x = x;
        this.y = y;
        this.skin = skin;
    }

    public void Transportar(ref int x, ref int y){
        // Transportar en esa direccion
        
        this.x = x;
        this.y = y;

        try{
            Partida.mapa[y,x] = skin;
            Partida.PrintCanvas();
        } catch(SystemException){
            Console.WriteLine("Error, desbordamiento");
        }
    }

    /* 0 -> up
       1 -> right
       2 -> down
       3 -> left
    */
    public void Move(int dir){
        // Mover en al direccion
        switch(dir){
            case 0:
                try{
                    Partida.mapa[y, x] = ' ';
                    y--;
                    Partida.mapa[y, x] = 'x';
                    Partida.PrintCanvas();
                } catch(SystemException){
                    Console.WriteLine("Error, desbordamiento");
                }
            break;
            case 1:
                try{
                    Partida.mapa[y, x] = ' ';
                    x++;
                    Partida.mapa[y, x] = 'x';
                    Partida.PrintCanvas();
                } catch (SystemException) {
                    Console.WriteLine("Error, desbordamiento");
                }    
            break;
            case 2:
                try{
                    Partida.mapa[y, x] = ' ';
                    y++;
                    Partida.mapa[y, x] = 'x';
                    Partida.PrintCanvas();
                } catch (SystemException) {
                    Console.WriteLine("Error, desbordamiento");
                }
            break;
            case 3:
                try{
                    Partida.mapa[y, x] = ' ';
                    x--;
                    Partida.mapa[y, x] = 'x';
                    Partida.PrintCanvas();
                } catch (SystemException) {
                    Console.WriteLine("Error, desbordamiento");
                }
            break;
        }
    }

/* 0 -> up
   1 -> right
   2 -> down
   3 -> left
            */

    public void Teclas() {
        switch (Console.ReadKey().Key) {
            case ConsoleKey.UpArrow:
                if (HeroCanMove(0)) {
                    Move(0);
                }
            break;
            case ConsoleKey.DownArrow:
                if (HeroCanMove(2)) {
                    Move(2);
                }
            break;
            case ConsoleKey.LeftArrow:
                if (HeroCanMove(3)) {
                    Move(3);
                }
            break;
            case ConsoleKey.RightArrow:
                if (HeroCanMove(1)) {
                    Move(1);
                }
            break;
        }
    }

    public void RemoveHero() {
        Partida.mapa[y,x] = ' ';
    }


    /* 0 -> up
       1 -> right
       2 -> down
       3 -> left
                */
    protected bool HeroCanMove(int dir) {
        switch (dir) {
            case 0:
                int copyy = y;
                copyy--;
                if(Partida.mapa[copyy, x].Equals(' ')){
                    return true;
                } else if(Partida.mapa[copyy, x].Equals('0')){
                    win = true;
                    return false;
                }
                return false;
            case 1:
                int copyx = x;
                copyx++;
                if (Partida.mapa[y, copyx].Equals(' ')) {
                    return true;
                } else if (Partida.mapa[y, copyx].Equals('0')) {
                    win = true;
                    return false;
                }
                return false;
            case 2:
                copyy = y;
                copyy++;
                if (Partida.mapa[copyy, x].Equals(' ')) {
                    return true;
                } else if (Partida.mapa[copyy, x].Equals('0')) {
                    win = true;
                    return false;
                }
                return false;
            case 3:
                copyx = x;
                copyx--;
                if (Partida.mapa[y, copyx].Equals(' ')) {
                    return true;
                } else if (Partida.mapa[y, copyx].Equals('0')) {
                    win = true;
                    return false;
                }
                return false;
            default:
                return false;
        }
    }
}
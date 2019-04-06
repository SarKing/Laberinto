using System;

public class Hero : Personaje{
    public bool win = false;

    // Si, no funciona
    public Hero(char skin, char arma, int maxVida, int damage) : base(skin, arma, maxVida, damage){

    }



    /* 0 -> up
       1 -> right
       2 -> down
       3 -> left
                */

    public void Teclas() {
        switch (Console.ReadKey().Key) {
            case ConsoleKey.UpArrow:
                if (CanMove(0)) {
                    Move(0);
                }
                break;
            case ConsoleKey.DownArrow:
                if (CanMove(2)) {
                    Move(2);
                }
                break;
            case ConsoleKey.LeftArrow:
                if (CanMove(3)) {
                    Move(3);
                }
                break;
            case ConsoleKey.RightArrow:
                if (CanMove(1)) {
                    Move(1);
                }
                break;
        }
    }

    protected override bool CanMove(int dir) {
        switch (dir) {
            case 0:
                int copyy = y;
                copyy--;
                if (Partida.mapa[copyy, x].Equals(' ')) {
                    return true;
                } else if (Partida.mapa[copyy, x].Equals('0')) {
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
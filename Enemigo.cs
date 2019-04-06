using System;

public class Enemigo : Personaje{
     


    public Enemigo(char skin, char arma, int maxVida, int damage, int x, int y) : base(skin, arma, maxVida, damage){
        this.x = x;
        this.y = y;
        Transportar(ref x, ref y);
    }

    public void Movimiento(){
        if(CanMove(1)){
            Move(1);
        } else {
            Move(3);
        }
    }   
}
using System;

public class Enemigo : Personaje{

    bool flag = false;

    public Enemigo(char skin, char arma, int maxVida, int damage, int x, int y) : base(skin, arma, maxVida, damage){
        this.x = x;
        this.y = y;
        Transportar(ref x, ref y);
    }

    public void Movimiento(){

        
        // Si no se puede mover hacia la derecha
        if(!CanMove(1)){
            flag = true;
        } else if (!CanMove(3)){
            flag = false;
        }

        if(flag == false){
            Move(1);
        } else if (flag == true){    
            Move(3);
        }


    }   
}
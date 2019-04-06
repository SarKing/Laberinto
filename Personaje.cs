using System;

public class Personaje{
    public int x = 0;
    public int y = 0;
    protected char skin;
    protected int damage;
    protected int vida;
    protected int maxVida;
    protected char arma;
    protected bool vivo = true;

     public Personaje(char skin, char arma, int maxVida, int damage){
        this.skin = skin;
        this.arma = arma;
        this.maxVida = maxVida; 
        this.vida = maxVida;
        this.damage = damage;
    }

    public void Transportar(ref int x, ref int y){
        // Transportar en esa direccion
        
        this.x = x;
        this.y = y;

        try{
            Partida.mapa[y,x] = skin;
            
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
                    Partida.mapa[y, x] = skin;
                    
                } catch(SystemException){
                    Console.WriteLine("Error, desbordamiento");
                }
            break;
            case 1:
                try{
                    Partida.mapa[y, x] = ' ';
                    x++;
                    Partida.mapa[y, x] = skin;
                    
                } catch (SystemException) {
                    Console.WriteLine("Error, desbordamiento");
                }    
            break;
            case 2:
                try{
                    Partida.mapa[y, x] = ' ';
                    y++;
                    Partida.mapa[y, x] = skin;
                    
                } catch (SystemException) {
                    Console.WriteLine("Error, desbordamiento");
                }
            break;
            case 3:
                try{
                    Partida.mapa[y, x] = ' ';
                    x--;
                    Partida.mapa[y, x] = skin;
                    
                } catch (SystemException) {
                    Console.WriteLine("Error, desbordamiento");
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


    // hay que sobreescribirlo en hero por que usa el atrbuto win;
    protected virtual bool CanMove(int dir) {
        switch (dir) {
            case 0:
                int copyy = y;
                copyy--;
                if(Partida.mapa[copyy, x].Equals(' ')){
                    return true;
                } else {
                    return false;
                }
            case 1:
                int copyx = x;
                copyx++;
                if (Partida.mapa[y, copyx].Equals(' ')) {
                    return true;
                } else {
                    return false;
                }
            case 2:
                copyy = y;
                copyy++;
                if (Partida.mapa[copyy, x].Equals(' ')) {
                    return true;
                } else {
                    return false;
                }
            case 3:
                copyx = x;
                copyx--;
                if (Partida.mapa[y, copyx].Equals(' ')) {
                    return true;
                } else {
                    return false;
                }
            default:
                return false;
        }
    }

    public void Atacar(){

    }

    public void Curar(int heal){
/*         int sum = vida + heal;
        if(sum >= maxVida){
            vida = maxVida;
        } else {
            vida = sum;
        } */
    }

    public void Damage(int dam){
/*         vida -= dam;
        if(vida <= 0){
            vivo = false;
        } */
    }

}
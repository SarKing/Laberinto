using System;

public class Personaje : Partida{

    // Vida...
    protected int x;
    protected int y;
    protected string skin;


    public Personaje(int x, int y, string skin){
        this.x = x;
        this.y = y;
        this.skin = skin;
        WriteAt(skin, x, y);
    }

    public void Mover(int x, int y){
        // Eliminas al anterior personaje

        // Mueves el personaje a la nueva posicion
        WriteAt(skin, this.x, this.y);
    }

    public void Teclas(){
        switch (Console.ReadKey().Key){
            case ConsoleKey.UpArrow:
                if(HeroCanMove(0)){
                    RemoveHero();
                    this.y--;
                    Mover(this.x, this.y);
                }
                    break;
            case ConsoleKey.DownArrow:
                if(HeroCanMove(2)){
                    RemoveHero();
                    this.y++;
                    Mover(this.x, this.y);
                }
                    break; 
            case ConsoleKey.LeftArrow:
                if(HeroCanMove(3)){
                    RemoveHero();
                    this.x--;
                    Mover(this.x,this.y);
                }
                    break;
            case ConsoleKey.RightArrow:
                if(HeroCanMove(1)){
                    RemoveHero();
                    this.x++;
                    Mover(this.x, this.y);
                }
                    break;
        }
    }

    public void RemoveHero(){
        WriteAt(".", this.x, this.y);
    }


    /* 0 -> top
       1 -> right
       2 -> bottom
       3 -> left
    */
    protected bool HeroCanMove(int pos){

        switch (pos){
            case 0:
                if(getY() - 1 <= 0){
                    return false;
                } else {
                    return true;
                }
                
            case 1:
                if(getX() + 1 >= WIDTH - 1){
                    return false;
                } else {
                    return true;
                }
                
            case 2:
                if(getY() + 1 >= HEIGHT - 1){
                    return false;
                } else {
                    return true;
                }
                
            case 3:
                if(getX() - 1 <= 0){
                    return false;
                } else {
                    return true;
                }
                
            
        }
        if(getX() + 1 >= WIDTH || getX() - 1 <= 0){
            return false;
        } else if(getY() + 1 >= HEIGHT || getY() - 1 <= 0){
            return false;
        } else {
            return true;
        }
    }


    public void setX(int x){
        this.x = x;
    }
    public void setY(int y){
        this.y = y;
    }

    public int getX(){
        return x;
    }
    public int getY(){
        return y;
    }
}
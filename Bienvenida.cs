using System;
public class Bienvenida : Pantalla{

    public static void Inicio(){
        Console.Clear();
        Console.WriteLine(@" 
    / /                                                                      
   / /         ___     / __      ___      __     ( )   __    __  ___  ___    
  / /        //   ) ) //   ) ) //___) ) //  ) ) / / //   ) )  / /   //   ) ) 
 / /        //   / / //   / / //       //      / / //   / /  / /   //   / /  
/ /____/ / ((___( ( ((___/ / ((____   //      / / //   / /  / /   ((___/ /  ");

        Console.WriteLine("Created by: sarking.");

        Console.WriteLine("\n\n\n\n\n\nPulsa 'n' para una nueva partida, 'x' para salir...");
    }
}
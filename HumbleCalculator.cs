using System;

public class HumbleCalculator
{
    public static double Calculate(double num1, double num2, int operation)
    {
        double resultado = 0;

        
        switch (operation)
        {
            case 1:
                resultado = num1 + num2;
                break; 
            
            case 2:
                resultado = num1 - num2;
                break;
            
            case 3:
                resultado = num1 * num2;
                break;
            
            default:
                Console.WriteLine("Error: Operación no válida.");
                break;
        }

      
        return resultado;
    }
}
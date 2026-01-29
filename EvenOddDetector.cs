using System;

public class EvenOddDetector
{
    public static string DetectEvenOdd(int number)
    {
        string resultado;
        if (number % 2 == 0)
        {
            resultado = "PAR";
        }
        else
        {
            resultado = "IMPAR";
        }
        
        return resultado;
    }
}

using System;


public class DoormanOfNightclub
{
public static string CheckAccess(int age)
{
    if (age < 18)
    {
        return "Fuera de aquí";
    }
    else if (age >= 18 && age <= 60)
    {
        return "Bienvenido a la fiesta";
    }
    else
    {
        return "Señor, el bingo es al lado";
    }
}
}

//Potencia un numero a la n potencia, con un exponente minimo de 0 y un maximo de 30, utilizando recursividad directa
using System;
class Program
{
    //Devuelve el resultado de la potencia
    static long Potencia(int baseNum, int exponente)
    {
        //Detiene la recursividad cuando exponente es igual a 0
        if (exponente == 0)
            return 1;

        //multiplica el numero base por el resultado de la potencia del numero base y el exponente anterior,
        //hasta llegar al caso base
        return baseNum * Potencia(baseNum, exponente - 1);
    }
    static void Main()
    {
        Console.Write("Ingresa la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        //Comprueba si el exponente esta dentro del rango
        Console.Write("Ingresa el exponente (0 a 30): ");
        int exponente = int.Parse(Console.ReadLine());

        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente fuera de rango.");
            return;
        }
        //Llama a la potencia
        Console.WriteLine("Resultado " + Potencia(baseNum, exponente));
        Console.WriteLine("|Por Gabriel Avalos y Yamil Castro|");
    }
}

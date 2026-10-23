//Objetivo: Calcular la suma de los numeros desde 1 hasta n utilizando dos metodos que se llaman mutuamente
using System;

class Program
{
    //Suma n + SumaB(n - 1), continua a SumaB de no ser n cero
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;
        return n + SumaB(n - 1);
    }

    //A SumaA le resta a n - 1, SumaA(n - 1). Se devuelve a SumaA si n no es cero
    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;
        return SumaA(n - 1);
    }
    static void Main()
    {
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        //Compruba si n esta dentro del rango
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000.");
            return;
        }
        //Llama a sumaA
        Console.WriteLine("La suma es: " + SumaA(n));
        Console.WriteLine("|Por Gabriel Avalos e Yamil Castro|");
    }
}
//Nota: Este programa no suma todos los numeros consecutivos: Suma los numero alternos. Para
//sumar del 1 al 5, el resultado correcto seria 15. El programa se incluye para observar como
//se alternan las llamadas; para una suma completa se puede modificar la estructura de los metodos
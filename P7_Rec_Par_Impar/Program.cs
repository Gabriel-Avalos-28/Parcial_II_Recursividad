//Comprueba si el n es un numero impar o par medinate recursividad indirecta
using System;

class Program
{
    //Le resta 1 a n, si este no es cero continua a EsImpar
    static bool EsPar(int n)
    {
        if (n == 0)
            return true;

        return EsImpar(n - 1);
    }
    //Le resta 1 a n, si este no es cero se devuelve a EsPar
    static bool EsImpar(int n)
    {
        if (n == 0)
            return false;
        return EsPar(n - 1);
    }
    static void Main()
    {
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        //Comprueba que n este dentro del limite
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingrese un numero entre 0 y 10000.");
            return;
        }
        //Verifica si EsPar(n) es verdadero
        if (EsPar(n))
            Console.WriteLine("El numero es par.");
        else
        {
            Console.WriteLine("El numero es impar.");
        }
        Console.WriteLine("|Por Gabriel Avalos e Yamil Castro|");
    }
}
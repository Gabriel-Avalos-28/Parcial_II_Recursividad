//Suma los numeros anteriores de n hasta 0, n teniendo un maximo de 10,000 y un minimo de 0, utilizando con un recursividad directa
using System;
class Program
{
    //Devuelve la Suma
    static int Suma(int n)
    {
        //Detiene la recursividad cuando n es menor o igual a 0
        if (n <= 0)
            return 0;

        //Suma n mas el resultado de suma del numero anterior, hasta llegar al caso base
        return n + Suma(n - 1);
    }
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        //Comprueba que el numero este dentro del rango (0 y 10,000)
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000");
            return;
        }
        //Llama la suma
        Console.WriteLine("La suma es: " + Suma(n));
        Console.WriteLine("|Por Gabriel Avalos y Yamil Castro|");
    }
}
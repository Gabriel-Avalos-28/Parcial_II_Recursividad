//Devuelve el numero en la posicion n de la serie Fibonacci hasta la posicion 40 utilizando recursividad directa
using System;

class Program
{
    //Devuelve la serie Fibonacci
    static int Fibonacci(int n)
    {
        
        //Detiene la recursividad cuando n es menor o igual a 1   
        if (n <= 1)
            return n;

        //Suma el resultado de la serie fibonacci del numero - 1 mas el resultado de la serie fibonacci del
        //numero -2, hasta llegar al caso base
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main()
    {
        Console.Write("Ingresa la posición: ");
        int n = int.Parse(Console.ReadLine());

        //Comprueba si la posicion esta dentro del rango
        if (n < 0 || n > 40)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 40.");
            return;
        }
        //LLama a la serie Fibonacci
        Console.WriteLine("Fibonacci: " + Fibonacci(n));
        Console.WriteLine("|Por Gabriel Avalos y Yamil Castro|");

    }
}
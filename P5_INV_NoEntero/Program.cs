// Invertir el orde de los digitos de un numero entero positivo mediante llamadas recursivas
using System;

class Program
{
    //Devuelve el numero invertido
    static long Invertir(long n, long resultado = 0)
    {
        //Detiene la recursividad cuando n es igual a 0, devolviendo el número invertido que se construyó
        if (n == 0)
            return resultado;

        //Elimina el último dígito de n y lo agrega al final de resultado para construir el número
        //invertido, despues, vuelve a llamar al método con esos valores.
        return Invertir(n / 10, resultado * 10 + n % 10);
    }

    static void Main()
    {
        Console.Write("Ingresa un numero positivo: ");
        long n = long.Parse(Console.ReadLine());

        //Comprueba que n sea positivo
        if (n < 0)
        {
            Console.WriteLine("El numero debe ser positivo.");
            return;
        }

        //Llama a Invertir
        Console.WriteLine("Numero invertido: " + Invertir(n));
        Console.WriteLine("|Por Gabriel Avalos y Yamil Castro|");
    }
}
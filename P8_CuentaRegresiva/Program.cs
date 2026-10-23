//Objetivo: Mostrar una cuenta regresiva desde un numero hasta cero utilizando dos metodos que se llaman entre si
using System;

class Program
{
    //Escribe n y le resta 1 a n en CuentasB, continua a CuentasB() si n no es cero
    static void CuentaA(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("A: " + n);
        CuentaB(n - 1);
    }

    //Escribe n y le resta 1 a n en CuentasA, regresa a CuentasA() si n no es cero
    static void CuentaB(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("B: " + n);
        CuentaA(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("|Por Gabriel Avalos e Yamil Castro|");
        Console.Write("Ingresa el numero inicial: ");
        int n = int.Parse(Console.ReadLine());

        //Comprueba si n esta dentro del rango
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 1000.");
            return;
        }

        //Escribe nuestro numero inicial
        CuentaA(n);
    }
}
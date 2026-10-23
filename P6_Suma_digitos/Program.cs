//Recursividad directa
//Objetivo: Sumar todos los digitos de un numero entero positivo.
//¿Como funciona? el metodo SumarDigitos() suma el ultimo digito con el resultado de llamarse a si mismo usando el numero sin ese digito
using System;

class Program
{
    //Devuelve la suma de los digitos
    static int SumarDigitos(int n)
    {
        //Detiene la recursividad cuando n es igual a 0
        if (n == 0)
            return 0;

        //Suma el último dígito de n con el resultado de SumarDigitos(n / 10), que procesa los dígitos restantes.
        return n % 10 + SumarDigitos(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        //Comprueba que n sea un numero positivo
        if (n < 0)
        {
            Console.WriteLine("Ingresa un numero positivo.");
            return;
        }

        //Llama a SumarDigitos()
        Console.WriteLine("Suma de digitos: " + SumarDigitos(n));
        Console.WriteLine("|Por Gabriel Avalos e Yamil Castro|");
    }
}
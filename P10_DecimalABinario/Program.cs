//Convierte un numero n a binario
using System;
class Program
{
    // Convierte el número a binario imprimiendo sus dígitos
    static void BinarioA(int n)
    {
        // Caso base: si n es 0 o 1, lo imprime y detiene la llamada
        if (n < 2)
        {
            Console.Write(n);
            return;
        }
        BinarioB(n / 2);
        Console.Write(n % 2);
    }
    static void BinarioB(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }
        // Llama a BinarioB con la mitad entera de n. Al regresar, imprime el residuo de dividir n entre 2
        BinarioA(n / 2);
        Console.Write(n % 2);
    }
    static void Main()
    {
        Console.WriteLine("|Por Gabriel Avalos e Yamil Castro")
        Console.Write("Ingresa un numero entero: ");
        int n = int.Parse(Console.ReadLine());
        //Comprueba que n sea positivo
        if (n < 0)
        {
            Console.WriteLine("Ingresa un numero no negativo: ");
            return;
        }
        Console.Write("Binario: ");
        //Comprueba si n es cero
        if (n == 0)
            Console.Write("0");
        else
            BinarioA(n);

        Console.WriteLine();
    }
}
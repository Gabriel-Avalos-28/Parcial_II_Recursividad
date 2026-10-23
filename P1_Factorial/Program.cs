//Devuelve el factorial de un numero entre 0 y 20 por medio de recursividad directa
class program
{
    //Devuelve el factorial de n
    static long Factorial(int n)
    {
        //Detiene la recursividad cuando n es 0
        if (n == 0)
            return 1;

        //Multiplica n por el resultado del factorial del número anterior, hasta llegar al caso base
        return n * Factorial(n - 1);
    }
    static void Main()
    {

        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());
        
        //Comprueba si el numero esta entre 0 y 20
        if (n < 0 || n > 20)
        {
            Console.WriteLine("Ingrese un numero entre 0 y 20.");
            return;
        }
        
        //Devuelve el factorial de n
        Console.WriteLine("Factorial: " + Factorial(n));
        Console.WriteLine("|Por Gabriel Avalos y Yamil Castro|");
    }
}
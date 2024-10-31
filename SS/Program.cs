using System;


//Factorial recursivo

/*
class Program
{
   
    static int Factorial(int n)
    {
        if (n <= 1) 
            return 1;
        else
            return n * Factorial(n - 1); 
    }

    static void Main()
    {
        Console.Write("Ingresa un número para calcular su factorial: ");

     
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
            else
            {
                int resultado = Factorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}
*/
//Suma de números naturales
/*

class Program
{
    
    static int SumaNaturales(int n)
    {
        if (n <= 1) 
            return n;
        else
            return n + SumaNaturales(n - 1); 
    }

    static void Main()
    {
        Console.Write("Ingresa un número para calcular la suma de los primeros n números naturales: ");

       
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero < 0)
            {
                Console.WriteLine("Por favor, ingresa un número positivo.");
            }
            else
            {
                int resultado = SumaNaturales(numero);
                Console.WriteLine($"La suma de los primeros {numero} números naturales es: {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}
*/

//Fibonacci recursivo




/*
class Program
{
  
    static int Fibonacci(int n)
    {
        if (n <= 1) 
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
    }

    static void Main()
    {
        Console.Write("Ingresa un número para calcular el enésimo número de Fibonacci: ");
        
        
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero < 0)
            {
                Console.WriteLine("Por favor, ingresa un número positivo.");
            }
            else
            {
                int resultado = Fibonacci(numero);
                Console.WriteLine($"El {numero}° número de Fibonacci es: {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}
 
 */
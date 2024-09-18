
using System;
using System.ComponentModel.Design;

class Program 
{ 
static void Main () { 
Console.Write("Ange vilket nummer i Fibonacciserien du vill ha: ");
int n = int.Parse(Console.ReadLine());

    int resultat = Fibonacci(n);
    Console.WriteLine($"Fibonacci {n} är {resultat}");

}

static int Fibonacci(int n)
{
    if (n <= 0)
        return 0;
    else if (n == 1)
    {
        return 1;

    }
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
}
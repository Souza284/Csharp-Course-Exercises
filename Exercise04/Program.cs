// Exercise04 - Fibonacci Sequence

Console.WriteLine("FIBONACCI SEQUENCE\nHow many terms do you want to see? ");
var terms = int.Parse(Console.ReadLine()!);

Fibonacci(terms);

static void Fibonacci(int terms)
{
    int n1 = 0;
    int n2 = 1;
    int n3 = n1 + n2;

    Console.Write($"{n1} {n2} {n3} ");
    
    for (var i = 0; i < terms; i++)
    {
        n1 = n2;
        n2 = n3;
        n3 = n1 + n2;
        Console.Write(n3 + " ");
    }
}

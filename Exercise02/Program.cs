// Exercise02 - Identity Matrix

Console.WriteLine("Number of lines: ");
var lines = int.Parse(Console.ReadLine()!);

Console.WriteLine("Number of columns: ");
var columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[lines, columns];

for (var i = 0; i < lines; i++)
{
    Console.WriteLine();
    
    for (var j = 0; j < columns; j++)
    {
        if (i != j)
        {
            matrix[i,j] = 0;
        }
        else
        {
            matrix[i,j] = 1;
        }

        Console.Write($"[ {matrix[i,j]} ]");

    }
}

// Exercise03 - Matrix Multiplication

#region Matrix A

Console.WriteLine("Matrix A\n");

Console.WriteLine("Number of lines: ");
var lines_A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Number of columns: ");
var columns_A = int.Parse(Console.ReadLine()!);

int[,] matrix_A = new int[lines_A, columns_A];

for (var i = 0; i < lines_A; i++)
{
    for (var j = 0; j < columns_A; j++)
    {
        Console.Write($"A[{i},{j}]: ");
        matrix_A[i, j] = int.Parse(Console.ReadLine()!);
    }
}

#endregion

Console.Clear();

#region Matrix B
Console.WriteLine("Matrix B\n");

Console.WriteLine($"The number of lines must be the same as the number of columns of Matrix A ({columns_A})");
var lines_B = columns_A;

Console.WriteLine("Number of columns: ");
var columns_B = int.Parse(Console.ReadLine()!);

int[,] matrix_B = new int[lines_B, columns_B];

for (var i = 0; i < lines_B; i++)
{
    for (var j = 0; j < columns_B; j++)
    {
        Console.Write($"B[{i},{j}]: ");
        matrix_B[i, j] = int.Parse(Console.ReadLine()!);
    }
}

#endregion

Console.Clear();

#region New Matrix

int[,] matrix_AB = new int[lines_A, columns_B];

for (var i = 0; i < lines_A; i++)
{
    Console.WriteLine();
    for (var j = 0; j < columns_B; j++)
    {
        for (var k = 0; k < columns_A; k++)
        {
            matrix_AB[i, j] += matrix_A[i, k] * matrix_B[k, j];
        }

        Console.Write($"[{matrix_AB[i, j]}]");
    }
}

#endregion

/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] A = new int[size, size];
int[,] B = new int[size, size];
RandomNumbers(A);
RandomNumbers(B);
int[,] C = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            C[i, j] = C[i, j] + (A[i, k] * B[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(B);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(C);
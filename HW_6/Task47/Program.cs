// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void printArray(int[,] matr)
{
for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine(); 
}
}

void fillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        matr[i, j] = new Random().Next(1, 100);
    }
}
int[,] matrix = new int[3,4];
printArray(matrix);
Console.WriteLine();
fillArray(matrix);
printArray(matrix);

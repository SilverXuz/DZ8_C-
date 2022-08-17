/*
Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[n, m];

void Array1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0,10);
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void Array2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(0,10);
            Console.Write(matrix2[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void Array1Array2(int[,] matrix12)
{
    for (int i = 0; i < matrix12.GetLength(0); i++)
    {
        for (int j = 0; j < matrix12.GetLength(1); j++)
        {
            matrix12[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    for (int i = 0; i < matrix12.GetLength(0); i++)
    {
        for (int j = 0; j < matrix12.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Array1(matrix1);
Console.WriteLine();
Array2(matrix2);
Console.WriteLine();
Array1Array2(matrix1);

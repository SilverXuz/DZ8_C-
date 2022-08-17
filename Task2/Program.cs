/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];
int[] arrayN = new int[n];
int sum = 0;
int minSumStringIndex = 1;

Array(matrix);

void Array(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,10);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arrayN[i] = sum;
        sum = 0; 
    }

    int minSumString = arrayN[0];
    minSumStringIndex = 1;
    for (int k = 0; k < arrayN.Length; k++)
        {
            if (arrayN[k] < minSumString)
                {
                    minSumString = arrayN[k];
                    minSumStringIndex = k + 1;
                }        
        }
    Console.WriteLine();
    Console.WriteLine(string.Join(" \t", arrayN));
    Console.WriteLine(minSumStringIndex + " строка");
}

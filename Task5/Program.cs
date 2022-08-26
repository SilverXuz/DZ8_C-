/*
Задача 62. 
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1   2  3 4
12 13 14 5
11 16 15 6
10  9  8 7
*/ 

//Решение из видео разбора от Дениса
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

void Array(int[,] matrix)
{
    int temp = 1, i = 0, j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i++;
    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}


Array(matrix);

// Решение от преподавателя
// int arraySizeX = 7;
// int arraySizeY = 4;
// int[,] testArray = new int[arraySizeX, arraySizeY];

// Console.Clear();
// Console.WriteLine($"Задача 62.");
// FillArrayInSpiral(testArray);
// PrintDoubleArray(testArray);

// void FillArrayInSpiral(int[,] array)
// {

//     int posI = 0;
//     int posJ = 0;
//     bool isItNewCircle = true;

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[posI, posJ] = i + 1;

//         if (posJ + 1 < array.GetLength(1) && isItNewCircle && array[posI, posJ + 1] == 0)
//         {
//             posJ++;
//             continue;
//         }
//         else
//         {
//             isItNewCircle = false;
//         }
        
//         if (posI + 1 < array.GetLength(0) && array[posI + 1, posJ] == 0)
//         {
//             posI++;
//             continue;
//         }
        
//         if (posJ - 1 >= 0 && array[posI, posJ - 1] == 0)
//         {
//             posJ--;
//             continue;
//         }
        
//         if (posI - 1 >= 0 && array[posI-1, posJ] == 0)
//         {
//             posI--;
//             continue;
//         }
//         else
//         {
//             posJ++;
//             isItNewCircle = true;
//         }
//     }
// }

// void PrintDoubleArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
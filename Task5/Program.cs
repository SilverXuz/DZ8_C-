/*
Задача 62. 
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1   2  3 4
12 13 14 5
11 16 15 6
10  9  8 7
*/ 

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

void Array(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] + i + j;
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }

}

// void SpiralArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(1) - 1; k++)
//             {
//                 if(matr[i, k] > matr[i, k + 1])
//                 {
//                     int x = matr[i, k + 1];
//                     matr[i, k + 1] = matr[i, k];
//                     matr[i, k] = x;                    
//                 }
//             }
//         }
//     }
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " \t");
//         }
//         Console.WriteLine();
//     }
// }

Array(matrix);
// Console.WriteLine();
// SpiralArray(matrix);

/*
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером  2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) 
*/

// Я не смог сделать проверку на повторяющиеся числа. Свои попытки закомментировал.
// И как вариант можно конечно записать kub[i, j, k] = 10; kub[i, j, k] = kub[i, j, k] + 1;
Console.WriteLine("Введите размер куба: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,,] kub = new int[n, n, n];

void ArrayKub(int[,,] kub)
{
    for (int i = 0; i < kub.GetLength(0); i++)
    {
        for (int j = 0; j < kub.GetLength(1); j++)
        {
            for (int k = 0; k < kub.GetLength(2); k++)
            {
                kub[i, j, k] = new Random().Next(10,99);
                Console.WriteLine(kub[i, j, k]);
                // Console.WriteLine(kub[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
        }   
    }
}

void Kub(int[,,] kub1)
{
    for (int i = 0; i < kub1.GetLength(0); i++)
    {
        for (int j = 0; j < kub1.GetLength(1); j++)
        {
            for (int k = 0; k < kub1.GetLength(2); k++)
            {
                // if (kub1[0, 0, 0] == kub1[1, 1, 1])
                //     kub1[1, 1, 1] = kub1[1, 1, 1] + 1;
                Console.WriteLine(kub1[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
        }
    }
    //     for (int i = 0; i < kub1.GetLength(0); i++)
    // {
    //     for (int j = 0; j < kub1.GetLength(1); j++)
    //     {
    //         for (int k = 0; k < kub1.GetLength(2); k++)
    //         {
    //             Console.WriteLine(kub1[i, j, k] + "(" + i + "," + j + "," + k + ")");
    //         }
    //     }
    // }
}

ArrayKub(kub);
Console.WriteLine();
Kub(kub);
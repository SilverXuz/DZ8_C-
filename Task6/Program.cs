/*
Задача 61(ДОП). Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/

// Этот код полностью украл с интернета. Совершенно не понял как самому решить задачу.
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine()); 
 
for (int y = 0; y < n; y++)
{
    int c = 1;
    for (int q = 0; q < n - y; q++)
    {
        Console.Write("   ");
    }
 
    for (int x = 0; x <= y; x++)
    {
        Console.Write("   {0:D} ", c);
        c = c * (y - x) / (x + 1);
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();


// Решение преподавателя

// Console.Write("Введите число элементов в основании треугольника Паскаля ");
// int n = int.Parse(Console.ReadLine() ?? "");
// int i, c;
// float factorial(int n)
// {
//     float i, x = 1;
//     for (i = 1; i <= n; i++)
//         x *= i;
//     return x;
//     }
// for (i = 0; i < n; i++)
// {
//     for (c = 0; c <= (n - i); c++) 
//         Console.Write(" ");
//     for (c = 0; c <= i; c++)
//     {
//         Console.Write(" ");
//         Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); 
//     }
//     Console.WriteLine();
//     Console.WriteLine(); 
// }
// Console.ReadLine();
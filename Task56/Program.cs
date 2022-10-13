// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int matrX = ReadData("Ввведите размер M ");
int matrY = ReadData("Введите размер N ");
int[,] matrix = new int[matrX, matrY];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrX; i++)
    {
        for (int j = 0; j < matrY; j++)
            matrix[i, j] = new Random().Next(1, 10);
    }
}

int collumMin(int[,] matrix)
{
    int indexMinSum = 0;
    
    int sumMin = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMinSum = i + 1;
        }
        }
    }
    return indexMinSum;
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"В {collumMin(matrix)} столбце минимальная сумма чисел");

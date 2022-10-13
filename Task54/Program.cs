// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matrix[i, j] = new Random().Next(0, 100);
    }
}
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write(arr[arr.Length - 1]);
}
void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}
void MaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = new int[matrX];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrX; k++)
                row[j] = matrix[i, j];
        }
        BubbleSort(row);
        Print1DArr(row);
        Console.WriteLine();
    }
}
FillArray(matrix);
Console.WriteLine("Случайный массив: ");
PrintArray(matrix);
Console.WriteLine("Отсортированный массив: ");
MaxToMin(matrix);

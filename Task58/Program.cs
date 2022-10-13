// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int size = ReadData("Ввведите размер массивов ");
int[,] matrixA = new int[size,size];
int[,] matrixB = new int[size,size];
void FillArray(int[,] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            matrix[i, j] = new Random().Next(1, 10);
    }
}
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

int [,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multiMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        multiMatrix[i,j] += matrixA[i,k] * matrixB[k,j];
                    }
                }
            }
            return multiMatrix;
}
FillArray(matrixA);
FillArray(matrixB);
System.Console.WriteLine("Матрица А");
PrintArray(matrixA);
System.Console.WriteLine("Матрица B");
PrintArray(matrixB);
System.Console.WriteLine("Произведение матриц А и В");
PrintArray(MatrixMultiplication(matrixA,matrixB));


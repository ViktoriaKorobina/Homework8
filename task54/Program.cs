// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





int WorkWithUser(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] FillMatrix(int r, int c, int min, int max)
{
    int[,] matrix = new int[r, c];
    Random rnd = new Random();
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mat)
{
    for (int rows = 0; rows < mat.GetLength(0); rows++)
    {
        Console.Write("(");
        for (int columns = 0; columns < mat.GetLength(1); columns++)
        {
            if (columns < mat.GetLength(1) - 1) Console.Write($"{mat[rows, columns]}, ");
            else Console.Write($"{mat[rows, columns]}");
        }
        Console.WriteLine(")");
    }
}

void Sorted(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1 - j; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;

                }
            }
        }
    }
}

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int minValue = WorkWithUser("Введите нижнюю границу диапазона чисел: ");
int maxValue = WorkWithUser("Введите верхнюю границу диапазона чисел: ");
int[,] matrix = FillMatrix(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
Sorted(matrix);
PrintMatrix(matrix);


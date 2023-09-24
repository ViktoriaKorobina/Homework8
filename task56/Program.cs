// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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
int[] SumOfElementRow(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        result[i] = sum;
    }
    return result;
}

int FindMinSumOfRow(int[] array)
{
    int min = array[0];
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            result = i;
        }
    }
    return result;
}

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int minValue = WorkWithUser("Введите нижнюю границу диапазона чисел: ");
int maxValue = WorkWithUser("Введите верхнюю границу диапазона чисел: ");
int[,] matrix = FillMatrix(rows, columns, minValue, maxValue);
PrintMatrix(matrix);
Console.WriteLine("Сумма элементов построчно:");
int[] arraySum = SumOfElementRow(matrix);
Console.WriteLine(String.Join(", ",arraySum));
Console.WriteLine($"Минимальная сумма элементов находится в {FindMinSumOfRow(arraySum) + 1} строке"); 
// Здесь к номеру строки прибавляется 1, так как человек в отличие откомпьютера считает строки с 1, а не с 0.
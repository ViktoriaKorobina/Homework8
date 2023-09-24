// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product[i, j] +=matrix1[i, k]*matrix2[k, j];
            }
        }
    }
    return product;
}

bool CheckingMatrix(int[,] matr1, int[,] matr2)
{
    return matr1.GetLength(1) == matr2.GetLength(0);
}

int[,] mat1 = FillMatrix(2, 3, 1, 9);// Здесь, чтобы упростить себе жизнь, сразу ввела аргументы
int[,] mat2 = FillMatrix(3, 3, 1, 9);
PrintMatrix(mat1);
Console.WriteLine();
PrintMatrix(mat2);
if (CheckingMatrix(mat1, mat2))
{
int[,] productMatrix = ProductMatrix(mat1, mat2);
Console.WriteLine();
PrintMatrix(productMatrix);
}
else Console.WriteLine("Матрицы нельзя перемножить");

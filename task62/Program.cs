// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] Spiral(int size)
{
    int[,] array = new int[size, size];
    int round = 0; 
    int k = 1;
    int i = 0;
    int j = 0;
    while (k <= size * size)
    {
        array[i, j] = k;
        if (i == round && j < size - round - 1) j++;
        else if (j == size - round - 1 && i < size - round - 1) i++;
        else if (i == size - round - 1 && j > round) j--;
        else if(j == round && i > round) i--;
        if (i == round + 1 && j == round)
        {
            round++;
        }
        k++;
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:00}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] spiral = Spiral(4);
PrintArray(spiral);

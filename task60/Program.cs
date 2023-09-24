// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int WorkWithUser(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,,] FillMatrix(int r, int c, int d)
{
    int[,,] matrix = new int[r, c, d];
    int fill = 10;
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            for (int k = 0; k < d; k++)
            {
                matrix[i, j, k] = fill;// Решила схитрить и заполнить двузначными числами, идущими попорядку
                fill++;
            }

        }
    }
    return matrix;
}
bool CheckExist(int rows, int columns, int depth) // Здесь проверяется можно ли заполнить
// генерируемую матрицу неповторяющимися двузначными числами, которых всего 90.
{
    return rows * columns * depth <= 90;
}

void PrintMatrix(int[,,] mat)
{
    for (int rows = 0; rows < mat.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mat.GetLength(1); columns++)
        {
            for (int depth = 0; depth < mat.GetLength(2); depth++)
            // В примере массив выводится при изменении индекса столбца, следом строки и только потом глубины,
            // мне показалось, что логичнее вывести, меняя первым индекс глубины.
            // Но вообще можно и как в примере, только поменять местами циклы.
            {
                if (depth < mat.GetLength(2) - 1) Console.Write($"{mat[rows, columns, depth]}({rows}, {columns}, {depth}), ");
                else Console.Write($"{mat[rows, columns, depth]}({rows}, {columns}, {depth})");
            }
            Console.WriteLine();
        }      
    }
}

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int depth = WorkWithUser("Введите глубину: ");
if(CheckExist(rows, columns, depth))
{
    int[,,] array3d = FillMatrix(rows, columns, depth);
    PrintMatrix(array3d);
}
else Console.WriteLine("Указанную матрицу построить нельзя");

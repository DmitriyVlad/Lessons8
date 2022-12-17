// Задача 58. Найти произведение двух матриц

int[,] mat = { { 2, 4 }, { 3, 2 } };
int[,] mat1 = { { 3, 4 }, { 3, 3 } };

Console.WriteLine("Даны две матрицы:");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"{mat[i, j]} ");
    }
    Console.Write(" | | ");
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"{mat1[i, j]} ");
    }
    Console.WriteLine();
}

int[,] res = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (i == 0 & j == 0) res[i, j] = mat[0, 0] * mat1[0, 0] + mat[0, 1] * mat1[1, 0];
        if (i == 0 & j == 1) res[i, j] = mat[0, 1] * mat1[0, 0] + mat[1, 1] * mat1[0, 1];
        if (i == 1 & j == 0) res[i, j] = mat[0, 0] * mat1[1, 0] + mat[1, 0] * mat1[1, 1];
        if (i == 1 & j == 1) res[i, j] = mat[0, 1] * mat1[1, 0] + mat[1, 1] * mat1[1, 1];
    }
}
Console.WriteLine();
Console.WriteLine("Произведение двух матриц равно:");

for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(res[i, j] + " ");
        }
        Console.WriteLine();
    }

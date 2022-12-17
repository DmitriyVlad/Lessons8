// Задача 62. Вывод спирального массива 4*4

int n = 4, m = 4;
    var a = array(n, m);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write((a[i, j]+10) + "  ");
        }
        Console.WriteLine();
    }

static int[,] array(int n, int m)
{
    var arr = CreateArray(n, m);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n / 2; j++)
        {
            var tmp = arr[i, j];
            arr[i, j] = arr[i, m - j - 1];
            arr[i, m - j - 1] = tmp;
        }
    }
    return arr;
}

static int[,] CreateArray(int n, int m)
{
    int[,] matrix = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return matrix;
}
 
// Задача 54 Отсортировать строки двумерного массива по убыванию

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void Insert(bool isRow, int dim, int[] source, int[,] massiv)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            massiv[dim, k] = source[k];
        else
            massiv[k, dim] = source[k];
    }
}

void Sort(int[] inArray)
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

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(matrix);

int rowArr = matrix.GetLength(0);
int colArr = matrix.GetLength(1);

Console.WriteLine();
Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[colArr];
for (int i = 0; i < rowArr; i++)
{
    for (int j = 0; j < colArr; j++)
        row[j] = matrix[i, j];
    Sort(row);
    Insert(true, i, row, matrix);
}
PrintArray(matrix);

Console.WriteLine();

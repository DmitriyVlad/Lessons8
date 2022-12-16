// Задача 56 Найти номер строки с минимальной суммой элементов

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10, 99);
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}

int index = 0;
int minsum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    if (i == 0)
    {
        minsum = sum;
    }
    else if (sum < minsum)
    {
        minsum = sum;
        index = i;
    }
}

Console.WriteLine($"Строка с минимальной суммой имеет номер  {index + 1}");

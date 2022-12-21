// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinSumInRow(array)}");

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
        for (int j = 0; j < arrayColumns; j++)
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] >= 0)
                Console.Write(" " + inputArray[i, j] + " ");
            else
                Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindMinSumInRow(int[,] inputArray)
{
    int resultRowNumber = 0;
    int currentRowSum = 0, minSum = 2147483647;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        currentRowSum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
            currentRowSum += inputArray[i, j];

        Console.WriteLine($"Cумма элементов {i} строки равна {currentRowSum}");
        if (currentRowSum < minSum)
        {
            minSum = currentRowSum;
            resultRowNumber = i;
        }
    }
    return resultRowNumber;
}
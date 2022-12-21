// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

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
SortRowsMaxToMin(array);
Console.WriteLine("Новый массив: ");
PrintArray(array);

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

void SortRowsMaxToMin(int[,] inputArray)
{
    int buf = 0;
    for (int indexRows = 0; indexRows < inputArray.GetLength(0); indexRows++)
    {
        for (int i = 0; i < inputArray.GetLength(1); i++)
        {
            for (int j = inputArray.GetLength(1) - 1; j > 0; j--)
            {
                if (inputArray[indexRows, j] > inputArray[indexRows, j - 1])
                {
                    buf = inputArray[indexRows, j - 1];
                    inputArray[indexRows, j - 1] = inputArray[indexRows, j];
                    inputArray[indexRows, j] = buf;
                }
            }
        }
    }
}

// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
Console.Clear();

Console.Write("Введите количество строк матрицы A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = FillArray(rowsA, columnsA, -9, 9);
int[,] matrixB = FillArray(rowsB, columnsB, -9, 9);
int[,] matrixC = new int[rowsA, columnsB];

Console.WriteLine("Исходные матрицы: ");
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);

if (columnsA != rowsB) Console.WriteLine("Такие матрицы нельзя перемножить");
else
{
    matrixC = MultMatrix(matrixA, matrixB);
    Console.WriteLine("Результат умножения: ");
    PrintArray(matrixC);
}

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

int[,] MultMatrix(int[,] matrA, int[,] matrB)
{

    int[,] resultMatrix = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
                resultMatrix[i, j] += matrA[i, k] * matrB[k, j];
        }
    }
    return resultMatrix;
}
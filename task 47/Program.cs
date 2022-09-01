// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[] inData()
{
    int[] ColumnsAndRows = new int[2];
    Console.WriteLine("Введите кол-во строк: ");
    ColumnsAndRows[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов: ");
    ColumnsAndRows[1] = Convert.ToInt32(Console.ReadLine());
    return ColumnsAndRows;
}

double[,] Matrix(int[] ColumnsAndRows)
{
    Random rnd = new Random();
    double[,] MatrixRealNumber = new double[ColumnsAndRows[0], ColumnsAndRows[1]];
    for (int i = 0; i < ColumnsAndRows[0]; i++)
    {
        for (int j = 0; j < ColumnsAndRows[1]; j++)
        {
            MatrixRealNumber[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
    return MatrixRealNumber;
}

void outMatrix(double[,] MatrixRealNumber)
{
    for (int i = 0; i < MatrixRealNumber.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < MatrixRealNumber.GetLength(1); j++)
        {
            Console.Write(" { " + MatrixRealNumber[i, j] + " } ");
        }
    }
}
outMatrix(Matrix(inData()));

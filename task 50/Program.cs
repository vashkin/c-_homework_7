/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет
*/

int[,] Matrix = new int[3, 4] {  { 1, 4, 7, 2 },
                                 { 5, 9, 2, 3 },
                                 { 8, 4, 2, 4 } };

int[] inData()
{
    int[] ColumnsAndRows = new int[2];
    Console.WriteLine("Введите строку: ");
    ColumnsAndRows[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец: ");
    ColumnsAndRows[1] = Convert.ToInt32(Console.ReadLine());
    return ColumnsAndRows;
}
/* Вывод матрицы
void outMatrix(int[,] MatrixRealNumber)
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
*/
void SearchElementMatrix(int[] ColumnsAndRows, int[,] Matrix)
{
    if (Matrix.GetLength(0) >= ColumnsAndRows[0])
    {
        if (Matrix.GetLength(1) >= ColumnsAndRows[1])
        {
            Console.WriteLine(Matrix[ColumnsAndRows[0], ColumnsAndRows[1]]);
        }
        else Console.WriteLine("Столбца " + ColumnsAndRows[1] + " не существует");
    }
    else Console.WriteLine("Строки " + ColumnsAndRows[0] + " не существует");

}

SearchElementMatrix(inData(), Matrix);
//outMatrix(Matrix);




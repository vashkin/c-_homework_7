/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
int[,] Matrix = new int[3, 4] {  { 1, 4, 7, 2 },
                                 { 5, 9, 2, 3 },
                                 { 8, 4, 2, 4 } };

float[] arithmeticMean(int[,] Matrix)
{
    float[] number = new float[4];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            number[j] = number[j] + Matrix[i, j];
            if (i == Matrix.GetLength(0) - 1)
            {
                number[j] = number[j] / Matrix.GetLength(0);
            }
        }
    }
    return number;
}
void outArr(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(" { " + arr[i] + " } ");
    }
}
Console.Write(" Среднее арифметическое каждого столбца: ");
outArr(arithmeticMean(Matrix));






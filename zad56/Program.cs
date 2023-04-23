// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
int[,] matrix = GetRandomMatrixint(3, 3, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
MinimumSumOfElements(matrix);

int[,] GetRandomMatrixint(int rows, int columns, int minValue, int maxValue)
{
  int[,] matrix = new int[rows, columns];

  var random = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = random.Next(minValue, maxValue + 1);
    }
  }

  return matrix;
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }

}
void MinimumSumOfElements(int[,] matrix)
{
    int minsum = 0;
    int index = 0;
    int sumrow = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
       minsum += matrix[0, k];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        sumrow += matrix[i, j];
        if (sumrow < minsum)
        {
           minsum = sumrow;
            index = i;
        }
    }
    Console.Write($"строкa с наименьшей суммой элементов {index + 1} ");
}










   

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] matrix = GetRandomMatrixint(5, 5, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
SortingDecreasingElements(matrix);
PrintMatrix(matrix);

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
void SortingDecreasingElements(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}


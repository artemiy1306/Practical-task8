// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] SpiralMatrix(int length)
{
  int[,] matrix = new int[length, length];
  int num = 1,
      column = length,
      row = length,
      zeroColumn = 0,
      zeroRow = 0;
    while (zeroColumn < column)
  {
    for (int i = zeroColumn; i < column; i++)
    {
      matrix[zeroRow, i] = num++;
    }
    column--;
    for (int j = zeroRow + 1; j < row; j++)
    {
      matrix[j, row - 1] = num++;
    }
    row--;
    for (int k = column - 1; k >= zeroColumn; k--)
    {
      matrix[column, k] = num++;
    }
    for (int l = row - 1; l > zeroRow; l--)
    {
      matrix[l, zeroColumn] = (num++);
    }
    zeroColumn++;
    zeroRow++;
  }
  return matrix;
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
      if (matrix[i, j] < 10)
      {
        Console.Write("0" + matrix[i, j]);
        Console.Write(" ");
      }
      else Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();

  }
}
PrintMatrix(SpiralMatrix(5));
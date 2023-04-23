// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
int rowsOneMatrix = 2;
int ColumsRowsMatrix = 2;
int ColumsTwoMatrix = 2;
int[,] matrixOne = GetRandomMatrixint(rowsOneMatrix, ColumsRowsMatrix, 1, 9);
PrintMatrix(matrixOne);
Console.WriteLine();
int[,] matrixTwo = GetRandomMatrixint(ColumsRowsMatrix, ColumsTwoMatrix, 1, 9);
PrintMatrix(matrixTwo);
Console.WriteLine();
int[,] resultMatrix= new int[rowsOneMatrix, ColumsTwoMatrix];
MatrixMultiplication(matrixOne,matrixTwo,resultMatrix);
PrintMatrix(resultMatrix);

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

void MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo,int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixOne.GetLength(1); k++)
      {
        sum += matrixOne[i,k] * matrixTwo[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
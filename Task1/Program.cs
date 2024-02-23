/* Задайте двумерный массив. Найдите элементы, у которых оба
// // индекса чётные, и замените эти элементы на их квадраты.
// // Пример
// //  2 3 4 3
// //  4 3 4 1 =>
// //  2 9 5 4

// // 4 3 16 3
// // 4 3 4  1
 4 9 25 4
 */

void Main()
{
    int[,] matrix = GenerateMatrix(4, 5, 0, 10);
    PrintMatrix(matrix);

    System.Console.WriteLine();

    ChangeMatrix(matrix);
    PrintMatrix(matrix);
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) 
        for (int j = 0; j < matrix.GetLength(1); j+=2)
            matrix[i,j] = (int) Math.Pow(matrix[i, j], 2);
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] myMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return myMatrix;
}

Main();
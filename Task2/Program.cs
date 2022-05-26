// Задать двумерный массив следующим правилом: Aₘₙ = m+n
//---------------------------------------------------------------------------------------------------+
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
            matrix[i,k] = i + k;
}
//---------------------------------------------------------------------------------------------------+
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write(matrix[i,k] + " ");
        Console.WriteLine();
    }
}
//---------------------------------------------------------------------------------------------------+
Console.Clear();
Console.WriteLine("Enter the number of lines: ");
int rows = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Enter the number of columnes: ");
int columnes = int.Parse(Console.ReadLine()?? "");

int[,] matrix = new int[rows,columnes];

FillArray(matrix);
PrintArray(matrix);

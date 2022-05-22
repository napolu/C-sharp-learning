/*
Задача 1.
Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую 
и последнюю строку массива.
*/
//попарно менять элементы, вложенный цикл не нужен
/*
int[,] CreateRandomMatrix(int lines,int columns)
{
    int [,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = new Random().Next(0,10);
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    return matrix;
}

int [,] LinesReplace(int [,] matrix,int lines,int columns)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0,i];
        matrix [0,i] = matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i] = temp;
    }
    return matrix;
}

void ShowMatrix( int [,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(4,7);
int n = new Random().Next(4,7);

int[,] myMatrix = CreateRandomMatrix(m,n);
LinesReplace(myMatrix,m,n);
ShowMatrix(myMatrix);
*/

/*
Задача 2.
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
*/
//тоже матрица должна быть квадратной, чтобы заменялось

/*
int[,] CreateRandomMatrix(int lines,int columns)
{
    int [,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = new Random().Next(0,10);
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    return matrix;
}

int[,] LinesForColumns(int[,] matrix, int lines, int columns)
{
    int[,] newMatrix = new int[matrix.GetLength(0),matrix.GetLength(0)];
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[i,j] = matrix[j,i];
            }
        }
    return newMatrix;
    }    
}

void ShowMatrix( int [,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of lines: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateRandomMatrix(m,n);
if(m==n)
    ShowMatrix(LinesForColumns(myMatrix,m,n));
else
    Console.WriteLine("Lines can't be changed to columns, matrix isn't square");

*/
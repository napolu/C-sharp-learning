//Задача 47. 
/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
Console.Write("Input horizontal size of matrix: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input vertical size of matrix: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m,n];
Random random = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((random.NextDouble() * 10),1) * new Random().Next(-1,2);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
*/


//Задача 50. 
/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого числа в массиве нет
*/

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

void MatrixCheck( int[,] matrix, int linesX, int columnsX)
{
    if(matrix.GetLength(0)<=linesX || matrix.GetLength(1)<=columnsX)
        Console.WriteLine("Element doesn't exist in the matrix");
    else
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i==linesX && j==columnsX)
                    Console.WriteLine("The element you are looking for is: " + matrix[i,j]);
                }
            }
        }    
}

int m = new Random().Next(4,11);
int n = new Random().Next(4,11);

int[,] myMatrix = CreateRandomMatrix(m,n);

Console.WriteLine("Input the coordinates of the element:");
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

MatrixCheck(myMatrix,x,y);
*/

//Задача 52. 
/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int[,] CreateMatrix(int lines,int columns)
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

void LinesAverage(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double average = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                average += matrix[i,j];
            }
            Console.WriteLine("Average of line " + i + " equals: " + average/matrix.GetLength(1));
        }
    
}

Console.Write("Input horizontal size of matrix: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input vertical size of matrix: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateMatrix(m,n);
LinesAverage(myMatrix);
*/
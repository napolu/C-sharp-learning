int[,] CreateRandomMatrix(int rows,int columns)
{
    int [,] matrix = new int[rows, columns];
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

int[,] SortMatrixRows(int[,] matrix)
{
    int temp = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if(matrix[i,j]<matrix[i,k])
                    { 
                        temp = matrix[i,j];
                        matrix[i,j] = matrix[i,k];
                        matrix[i,k] = temp;
                    }
            }            
        }
    }
    return matrix;
}

void ShowMatrix( int[,] matrix)
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

void RowElementSum (int[,] matrix)
{    
    int sum=0, minSum=0, rowOfMin=0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        Console.WriteLine("Row " + i + ": "+ sum);

        if(i == 0)
        {
            minSum = sum;
            rowOfMin = i;
        } 

        if(sum < minSum)
        {
            minSum = sum;
            rowOfMin = i;
        }  
    }
    Console.WriteLine("The minimal sum of elements is found in row " + rowOfMin);    
}

int[,] SpiralMatrix(int M, int N)
{
    int [,] matrix = new int[M, N];
    int n=0;
    int m=-1;
    int direction=0;
    int length=M*N,i=0,j=0;
    for (int fillMatrix=1; fillMatrix<=length;fillMatrix++)
    {
        matrix[i, j]=fillMatrix;

        if (direction==0)
            j++; //вправо
        else if (direction==1)
            j--; //влево
        else if (direction==2)
            i++; //вниз
        else
            i--; //вверх
        
        if (direction==0 && j==N)
        {
            j--;
            i++;
            direction=2;
            N--;
        }
          else if (direction==1 && m==j)
        {
            j++;
            i--;
            direction=3;
            m++;
        }
        else if (direction==2 && i==M)
        {
            i--;
            j--;
            direction=1;
            M--;
        }
        else if (direction==3 && n==i)
        {
            i++;
            j++;
            direction=0;
            n++;
        }
    }
   return matrix; 
}

/*Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по возрастанию элементы 
каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

/*
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateRandomMatrix(rows,columns);
SortMatrixRows(myMatrix);
ShowMatrix(myMatrix);
*/

/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateRandomMatrix(rows,columns);
RowElementSum(myMatrix);
*/

/*
Задача 62. 
Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

/*
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = SpiralMatrix(rows,columns);
ShowMatrix(myMatrix);

*/
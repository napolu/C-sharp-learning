/*
//Задача из дз про посчитать положительные числа, кот ввёл пользователь
Console.Write("Input number of elements: ")
int kol = Convert.ToInt32(Console.ReadLine());

int count = 0;
int num;

for (int i = 0; i < kol; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if(num > 0) count++;
}

Console.WriteLine("Number of positive elements is " + count);
//это д.з. про подсчёт положительных чисел
//в этом решении плюс - не надо выделять память под целый массив, 
//более экономичное решение

*/

/*
//Задача из дз про перевод в двоичный код
int num = 45;
string boolNumber = string.Empty; //булевое число логическое

while(num > 0)
{
    boolNumber = (num%2) + boolNumber;//остаток от деления записывается
    //в начале строки, зависит от места слагаемого
    num/=2;
}
Console.WriteLine(boolNumber);
*/

/*
//Задача про пересечение прямых
b отвечает за высоту, на кот прямая пересекает ось Y
k отвечает за наклон отн-но оси X (tg этого угла)
точка пересечения имеет такие координаты, кот удовлетворяют обоим уравнениям,
значит их можно решить как систему уравнений.
*/

//Задача
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. 
//Выведите полученный массив на экран.
/*
void CreateMatrix(int sizeHoriz, int sizeVert)
{
    int[,] matrix = new int[sizeHoriz,sizeVert];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    
}
Console.Write("Input number of lines: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

CreateMatrix(line,column);
*/



//Задача 3.
//Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
/*
int SumOfDiagonal(int[,] quad)
{
    int sum = 0;

    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i,i];
    }
    return sum;
}

Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [size, size];

for (int i = 0; i < matrix.GetLength(0); i++)//getLength измерения 0 
    {                                        //- внешний цикл идёт по строкам
        for (int j = 0; j < matrix.GetLength(1); j++)//getLength измерения 1
        {                                            //внутренний цикл идёт по столбцам
            matrix[i,j] = new Random().Next(0,10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
  Console.WriteLine(SumOfDiagonal(matrix));
*/

//Задача 2.
//Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
//метод должен брать на вход массив и возвращать тоже должен массив

/*
int[,] MatrixTransform(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i%2==0 && j%2==0)
                    matrix[i,j] *= matrix[i,j];
                Console.Write(matrix[i,j] + " ");
            }
        }
    return matrix;
}
*/

//или
//вариант, где просто сразу задаётся возведение в квадрат элементов с чётными индексами
//без выведения массива и без проверок всего ещё раз по кругу
/*
int[,] MatrixTransform2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
    return matrix;
}
*/
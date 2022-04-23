/*
//Задача 1.

int NaturalSum(int a)
{
    int sum = 0;
    if(a < 1) return 0;
    else
    {
        for( int i = 1; i <= a; i++)
        {
            sum = sum + i;
            //sum += i; альтернативный вариант записи предыдущей строки, делает то же самое
        }
        return sum;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of elements is " + NaturalSum(num));
*/

/*
//Задача 2.
//Программа, кот.принимает на вход число и выдаёт кол-во цифр в нём

int CypherCount (int n)
{
    int count = 0;
    while(n > 0)
        {
            n = n/10;
            count++;
        }
    return count;    
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of cyphers is " + CypherCount(num));
*/

/*
int Factorial(int n)
{
    int factor = 1;

    if(n <= 0) return 0;
    else
    {
        for(int i = 1; i <= n; i++)
        {
            factor = factor * i;
            //factor*= i
        }
        return factor;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial = " + Factorial(num));

*/

/*
//Задача 3
int[] PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
        Console.Write(arr[i] + " ");
    }
    return arr;
}

int[] array = new int[8];
PrintArray(array);

*/

//Задача 4
//Нужно задать массив из 12 элементов, заполненный случайными числами
//из промежутка от -9 до 9, 
//и найти сумму отрицательных и положительных элементов массива



int[] CreateRandomArray(int size, int min, int max)//размер массива опр-ся переменной size 
{
    int[] array = new int[size];//выделение памяти, поль-ль запросил длину массива размером в size
    //это статич. массив, размер менять не сможет в процессе
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);//заполнение случ числами в нужном диапазоне
    }
    return array;
}


 int[] CreateArray(int size)//просто создать массив, не случ образом
{
    int[] array = new int[size];//выделение памяти
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input" + i + "element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());//ввод чисел вручную
    }

    return array;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


void FindSumOfElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            plusSum+= array[i];
        else
            minusSum += array[i];
    }
    Console.WriteLine("Sum of positive elements is " + plusSum);
    Console.WriteLine("Sum of negative elements is " + minusSum);
}

  int[] myArray = CreateRandomArray(6, -5, 5); //кол-во элем, мин, макс
  ShowArray(myArray);
  FindSumOfElements(myArray);
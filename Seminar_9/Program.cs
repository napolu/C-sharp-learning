//польз задаёт число N, нужно написать рекурсивный метод, который
// выведет все натур числа от 1 до N
/*
void NaturalNums (int n)
{
    if(n >= 1)
    {
        NaturalNums(n - 1);
        Console.Write(n + " ");
    }
}
NaturalNums(6);
*/
/*
Задача.
написать рекурсивный метод, который принимает 2 числа 
и возводит первое в степень, равную второму числу
*/

int XtoPowerofY(int n, int m)
{
   if(m >= 1)
    {
        m -= 1;
        return n * XtoPowerofY(n, m);
    }
    else
        return 1;
}
Console.Write(XtoPowerofY(5,3));

// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите натуральное число N: ");
int numerFerst = UserEnterNumerConsol();
Console.Write("Введите натуральное число M: ");
int numerSecond = UserEnterNumerConsol();
Console.Write("Сумма всех натуральных чисел от M до N : ");
Console.WriteLine(ResultOutput(numerFerst, numerSecond));

int UserEnterNumerConsol()
{
    int enterNumer = int.Parse(Console.ReadLine());
    if (enterNumer < 0 || enterNumer == 0)
    {
        Console.Write("Введите натуральное число (это число от 1 до ++)! : ");
        enterNumer = UserEnterNumerConsol();
        return (enterNumer);
    }
    else
    { return (enterNumer); }
}

int ResultOutput(int numerN, int numerM)
{
    if (numerN == numerM)
    { return (numerM); }
    else if (numerN > numerM)
    { return (numerM + ResultOutput(numerN, numerM + 1)); }
    else //if (numerN < numerM)
    { return (numerM + ResultOutput(numerN, numerM - 1)); }
}

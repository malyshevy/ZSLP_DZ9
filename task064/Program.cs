// Задача 64: Задайте значения N, М. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до M. 
//Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите натуральное число N: ");
int numerFerst = UserEnterNumerConsol();
Console.Write("Введите натуральное число M: ");
int numerSecond = UserEnterNumerConsol();
Console.Write(ResultOutput(numerFerst, numerSecond));

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

string ResultOutput(int numerN, int numerM)
{
    if (numerN == numerM)
    { return (numerN.ToString()); }
    else if (numerN > numerM)
    { return (ResultOutput(numerN, numerM + 1) + "," + numerM.ToString()); }
    else //if (numerN < numerM)
    { return (ResultOutput(numerN, numerM - 1) + "," + numerM.ToString()); }
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите натуральное число N: ");
int numerFerst = UserEnterNumerConsol();
Console.Write("Введите натуральное число M: ");
int numerSecond = UserEnterNumerConsol();
Console.WriteLine("Значение функции Аккермана : ");
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
    if (numerN == 0)
    { return (numerM + 1); }
    else if (numerN != 0 && numerM == 0)
    { return (ResultOutput(numerN - 1, 1)); }
    if (numerN > 0 && numerM > 0)
    { return (ResultOutput(numerN - 1, ResultOutput(numerN, numerM - 1))); }
    else
    { return (ResultOutput(numerN, numerM)); }
}

using System;
using MoneyClass;

class Program
{
    static void Main()
    {
        Money summa1 = new Money();
        Money summa2 = new Money();
        Console.WriteLine("VALUE FOR summa1:");
        summa1.SetCount();
        Money summa3 = new Money(summa1);
        Console.WriteLine(summa1.MakeSum());
        Console.WriteLine();
        Console.WriteLine("VALUE FOR summa2:");
        summa2.SetCount();
        Console.WriteLine(summa2.MakeSum());
        Console.WriteLine();
        Console.WriteLine($"Add of summa1 and summa2: {summa1 + summa2}");
        Console.WriteLine($"Substraction of summa1 and summa2: {summa1 - summa2}");
        Console.WriteLine($"Division of summa1 and summa2: {summa1 / summa2}");
        Console.WriteLine($"Division of summa1 and divisor: {summa1 / 2.5}");
        Console.WriteLine($"Multiply of summa1 and divisor: {summa1 * 4.7}");
        Console.WriteLine($"Operation > of summa1 and summa2: {summa1 > summa2}");
        Console.WriteLine($"Operation < of summa1 and summa2: {summa1 < summa2}");
        Console.WriteLine($"Operation >= of summa1 and summa2: {summa1 >= summa2}");
        Console.WriteLine($"Operation <= of summa1 and summa2: {summa1 <= summa2}");
        Console.WriteLine($"Operation == of summa1 and summa2: {summa1 == summa2}");
        Console.WriteLine($"Operation == of summa1 and summa3: {summa1 == summa3}");
        Console.WriteLine($"Operation != of summa1 and summa2: {summa1 != summa2}");
        Console.WriteLine($"Operation > of summa1 and number: {summa1 > 100000}");
        Console.WriteLine($"Operation < of summa1 and number: {summa1 < 20000}");
        Console.WriteLine($"Operation >= of summa1 and number: {summa1 >= 300000}");
        Console.WriteLine($"Operation <= of summa1 and number: {summa1 <= 1500000}");
        Console.WriteLine($"Operation == of summa1 and number: {summa1 == 121232}");
        Console.WriteLine($"Operation != of summa1 and number: {summa1 != 1329123}");
    }
};
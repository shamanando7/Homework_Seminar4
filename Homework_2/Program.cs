// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе



int SumAllNumbers(int number)
{
    int index = number.ToString().Length;
    int count = 0;
    int result = 0;
    int digit = number;
    while (count < index)
    {
        digit = number % 10;
        result = digit + result;
        number = number/ 10;
        count++;
    }
    return result;
}

Console.WriteLine("vvedite chislo");
int digit = int.Parse(Console.ReadLine()!);

if (digit == 0)
{
    Console.WriteLine("0");
    return;
}
else if (digit < 0)
{
    //  digit = digit * -1;
    Console.WriteLine("vvedite polozshitelnoe chislo");
    return;
}

Console.WriteLine(SumAllNumbers(digit));
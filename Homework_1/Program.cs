// Напишите цикл (функцию), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 




int Stepen(int A, int B)
{
    int result = 1;

    for (var index = 1; index <= B; index++)
        result = result * A;

    return result;
}

Console.WriteLine("vvedite chislo");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("vvedite chislo dlya vozvedeniya A v naturalnuyu stepen B");
int numberB = int.Parse(Console.ReadLine()!);

int result = Stepen(numberA, numberB);
if (numberB < 0)
    Console.WriteLine("Степень должна быть натураньным числом");
else if (numberB == 0)
    Console.WriteLine("1");
else
    Console.WriteLine(result);






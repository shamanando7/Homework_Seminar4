// Напишите программу, которая задает массив из 8 элементов и выводит их на экран. 
// Если что рандомные числа в задании специально ограничены трехначными числами

int[] CreateArray()                                  
{

    int[] array = new int[8];

    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 1000);
    return array;
}

var array = CreateArray();                           

for (int i = 0; i < 8; i++)
    Console.Write(" " + array[i]);


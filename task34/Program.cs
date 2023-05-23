// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//объявление метода с вводом длины "size" массива и границ значений
int[] Massiv(int size, int minValie, int maxValie) 
{
    //определение массива целых чисел
    int[] num;
    //определение переменной num и выделение памяти 
    //для size элементов массива
    num = new int[size];
    //заполнение массива в цикле случайными числами
    //в диапазоне от minValie до maxValie
    for (int i=0; i<size; i++)
    {
        num[i] = new Random().Next(minValie, maxValie+1);
        Console.WriteLine($"{num[i]}");
    }
    return num;
}

int[] array = Massiv(4,0,1000);

Console.WriteLine($" ");

foreach (int el in array)
{
Console.WriteLine($"{el}");
}



Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int ost = number%10;
if (ost == 0 || ost == 2 || ost == 4 || ost == 6 || ost == 8)
{
    Console.WriteLine("Число чётное");
}
else Console.WriteLine("Число нечётное");
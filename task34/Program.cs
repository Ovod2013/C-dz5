﻿// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Определение массива array, вызов метода Massiv с 
//переданными ему длиной массива 4, минимальным 
//значением от 100 (100 входит в диапазон), максимальным 
//значением до 1000 (1000 не входит в диапазон) и 
//присвоение элементам массива переменной array
//значений элементов массива Massiv
int[] array = Massiv(4,100,1000);
//Вызов метода SummaChetnyx и передача ему массива array
KolChetnyx(array);

//объявление метода Massiv с вводом длины "size" массива и 
//границ значений minValie  maxValie
int[] Massiv(int size, int minValie, int maxValie) 
{
    //определение массива целых чисел
    int[] num;
    //определение переменной num и выделение памяти 
    //для size элементов массива
    num = new int[size];
    //заполнение массива в цикле случайными числами
    //в диапазоне от minValie до maxValie
Console.WriteLine("Массив положительных трёхзначных чисел, заданных случайном образом:");

    for (int i=0; i<size; i++)
    {
        num[i] = new Random().Next(minValie, maxValie+1);
        Console.Write($"{num[i]}");
        Console.Write(" ");
    }
    return num;// Возврат массива
}


//Объявление метода SummaChetnyx определения чётного числа, 
//вычисления количества чётных чисел
//и выдача результата на консоль
// Метод ничего не выдаёт назад, только на консоль
void KolChetnyx(int[] t)
{
     int kolChetnyx=0;//Определение переменной summaChetnyx.
     //Присвоение начального значения "0"

//Хитрый цикл foreach, который пробегает все 
//элементы конкретного массива. 
//Здесь массив array.
//Значения элементов массива присваиваются 
//переменной el, с которой можно производить какие-то действия
foreach (int el in array)
{
    int ost = el%10;
    if (ost == 0 || ost == 2 || ost == 4 || ost == 6 || ost == 8)
{
    kolChetnyx+=1;
   }
    else kolChetnyx+=0;
}

Console.WriteLine();
if (kolChetnyx == 0) Console.WriteLine($"Чётных чисел нет");
else Console.WriteLine($"Количество чётных чисел = {kolChetnyx}");
}

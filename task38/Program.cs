// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

//Определение массива array, вызов метода Massiv с 
//переданными ему длиной массива 4, минимальным 
//значением от 100 (100 входит в диапазон), максимальным 
//значением до 1000 (1000 не входит в диапазон) и 
//присвоение элементам массива переменной array
//значений элементов массива Massiv
int[] array = Massiv(4,100,1000);
//Вызов метода SummaChetnyx и передача ему массива array
MinimElementMassiva(array);

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


//Объявление метода SummaChetnyx определения минимального 
//элемента массива и возврат этого элемента

void MinimElementMassiva(int[] arr)
{
     int minimElementMassiva=0;//Определение переменной minimElementMassiva.
     //Присвоение начального значения "0"

//Хитрый цикл foreach, который пробегает все 
//элементы конкретного массива. 
//Здесь массив array.
//Значения элементов массива присваиваются 
//переменной el, с которой можно производить какие-то действия
foreach (int el in array)
    {
    if (minimElementMassiva>el) minimElementMassiva=el;
    else minimElementMassiva=minimElementMassiva+0;
           }

Console.WriteLine(minimElementMassiva);
//if (summaNeChetnyx == 0) Console.WriteLine($"Нечётных чисел нет");
//else Console.WriteLine($"Сумма нечётных чисел в массиве = {summaNeChetnyx}");
}



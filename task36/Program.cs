// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Определение массива array, вызов метода Massiv с 
//переданными ему длиной массива 4, минимальным 
//значением от 100 (100 входит в диапазон), максимальным 
//значением до 1000 (1000 не входит в диапазон) и 
//присвоение элементам массива переменной array
//значений элементов массива Massiv
int[] array = Massiv(4,100,1000);
//Вызов метода SummaChetnyx и передача ему массива array
SummaNeChetnyx(array);

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


//Объявление метода SummaChetnyx определения чётности числа, 
//вычисления суммы нечётных чисел
//и выдача результата на консоль
// Метод ничего не выдаёт назал, только на консоль
void SummaNeChetnyx(int[] t)
{
     int summaNeChetnyx=0;//Определение переменной summaNeChetnyx.
     //Присвоение начального значения "0"
     int summaChetnyx=0;//Определение переменной summaChetnyx.
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
    summaChetnyx=summaChetnyx+el;
    
   }
    else summaNeChetnyx=summaNeChetnyx+el;
    //Console.WriteLine($"{summaNeChetnyx}");
}

Console.WriteLine();
if (summaNeChetnyx == 0) Console.WriteLine($"Нечётных чисел нет");
else Console.WriteLine($"Сумма нечётных чисел в массиве = {summaNeChetnyx}");
}


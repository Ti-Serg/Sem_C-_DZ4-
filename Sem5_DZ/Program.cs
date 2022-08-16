void Zadacha34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    int size = 10;
    int[] array = new int[size];   
    FillArray(array);
    PrintArray(array);
    SearchNum(array, 10);
}

void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    int size = 10;
    int[] array = new int[size];   
    FillArray(array, -99, 99);
    PrintArray(array);
    Summ(array, 10);
}

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    int size = 10;
    int minNum = 9;
    int maxNum = -9;
    int[] array = new int[size];   
    FillArray(array, -9 , 9);
    PrintArray(array);
    for (int a = 0; a < size; a++)
        if (array[a] < minNum) minNum = array[a];
        else if (array[a] > maxNum) maxNum = array[a];
    Console.WriteLine("Минимальный элемент массива " + minNum);
    Console.WriteLine("Максимальный элемент массива " + maxNum);
    int diff = 0;
    diff = maxNum - minNum;
    Console.WriteLine("Разница между максимальным и минимальным элементов массива " + diff);
    }

/*
void Zadacha38_fail()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    int size = 10;
    int minNum;
    int maxNum;
    int[] array = new int[size];   
    FillArray(array, -9 , 9);
    PrintArray(array);
    MaxElement(array, 10, -9, -9);
    MinElement(array, 10, 9, 9);
    Diff(minNum, maxNum);
    }
*/

void Diff(int minNum, int maxNum)
{
    int diff = maxNum - minNum;
    Console.WriteLine("Разница между максимальным и минимальным элементов массива " + diff);
}

void MinElement(int[] array, int size, int finishNumber, int minNum)
{
    minNum = finishNumber;
    for (int a = 0; a < size; a++)
        if (array[a] < minNum) minNum = array[a];
    
    Console.WriteLine("Минимальный элемент массива " + minNum);
}

void MaxElement(int[] array, int size, int startNumber, int maxNum)
{
    maxNum = startNumber;
    for (int a = 0; a < size; a++)
        if (array[a] > maxNum) maxNum = array[a];
    
    Console.WriteLine("Максимальный элемент массива " + maxNum);
}


void Summ(int[] array, int size)
{
    int sum = 0;
    for (int a = 0; a < size; a = a + 2)
    sum = sum + array[a];
    Console.WriteLine("Сумма элементов, стоящих на нечетных местах " + sum);
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 999 )
{
    finishNumber++;
    Random rand = new Random();
    for (int a = 0; a < array.Length; a++) 
    {
         array[a] = rand.Next(startNumber, finishNumber);    
    }
}

void PrintArray(int []array)
{
    Console.WriteLine("Вывод массива");
    for (int a = 0; a < array.Length; a++) 
    {
         Console.Write(array[a] + "  ");      
    }
    Console.WriteLine();
}

void SearchNum(int[] array, int size)
{
    int count = 0;
    for (int a = 0; a < size; a++)
    {
        if (array[a] % 2 == 0 ) count++;
    }

    Console.WriteLine("Количеств четных элементов в массиве - " + count);
}


//Zadacha34();
//Zadacha36();
//Zadacha38_fail();
Zadacha38();
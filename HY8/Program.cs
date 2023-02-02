﻿/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3
8 4 2 4

5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
 строки с наименьшей суммой элементов: 1 строка*/

 int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinRow(int[,] array)
{
    int minSum = 0;
    int numRow = 0;
    for(int i = 0, j = 0; j < array.GetLength(1); j++) 
        minSum = minSum + array[i, j];

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if(sum < minSum) 
        {
            minSum = sum;
            numRow = i;
        }
    }
    return numRow + 1;
}
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 

int result = MinRow(myArray);
Console.WriteLine( "Номер строки с наименьшей суммой элементов"   + result);
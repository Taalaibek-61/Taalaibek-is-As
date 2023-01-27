/*int [,] GreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passlble value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passlble value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int [rows, colums];
         for(int i = 0; i < rows; i++)
         {
            for(int j = 0; j < colums; j++)
                array[i,j] = new Random().Next(minValue, maxValue +1);
         }
    return array;
}    

void Show2dArray(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");
            
         Console.WriteLine();

    }
    Console.WriteLine();
}


 
int[,] myArray = GreateRandom2dArray();
 Show2dArray(myArray);*/


/*Задайте двумерный массив размера m на n, каждый элемент
 в массиве 
находится по формуле: Aij = i+j. Выведите полученный массив на экран.*/

/*int[,] CreateRandom2dArray() 
{ 
    Console.Write("Input a number of rows: "); 
    int rows= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a number of columns: "); 
    int columns= Convert.ToInt32(Console.ReadLine()); 
 
 
 
    int[,] array = new int[rows, columns]; // Выделение памяти для двумерного массива 
 
    for(int i=0; i < rows; i++) 
        for(int j=0; j < columns; j++) 
            array[i,j] = i + j; 
         
 
    return array; 
} 
 
void Show2dArray(int[,] array) 
{ 
    for(int i =0; i < array.GetLength(0); i++ ) 
    { 
        for(int j=0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
    Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 
 
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray);*/


/*Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.*/

/*int[,] CreateRandom2dArray() 
{ 
    Console.Write("Input a number of rows: "); 
    int rows= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a number of columns: "); 
    int columns= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a min possible value: "); 
    int minValue= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a max possible value: "); 
    int maxValue= Convert.ToInt32(Console.ReadLine()); 
 
 
    int[,] array = new int[rows, columns]; // Выделение памяти для двумерного массива 
 
    for(int i=0; i < rows; i++) 
        for(int j=0; j < columns; j++) 
            array[i,j] = new Random().Next(minValue, maxValue + 1);  
     
    return array; 
} 
 
void Show2dArray(int[,] array) 
{ 
    for(int i =0; i < array.GetLength(0); i++ ) 
    { 
        for(int j=0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
    Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 
 
void SquaNumbers(int[,] array) 
{ 
      for(int i=0; i < array.GetLength(0); i+=2) 
        for(int j=0; j < array.GetLength(1); j+=2) 
            array[i,j] = array[i,j]*array[i,j]; 
} 
 
 
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
SquaNumbers(myArray); 
Show2dArray(myArray);*/

/*Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.*/

/*int[,] CreateRandom2dArray() 
{ 
    Console.Write("Input a number of rows: "); 
    int rows= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a number of columns: "); 
    int columns= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a min possible value: "); 
    int minValue= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a max possible value: "); 
    int maxValue= Convert.ToInt32(Console.ReadLine()); 
 
 
    int[,] array = new int[rows, columns]; // Выделение памяти для двумерного массива 
 
    for(int i=0; i < rows; i++) 
        for(int j=0; j < columns; j++) 
            array[i,j] = new Random().Next(minValue, maxValue + 1);  
     
    return array; 
} 
 
void Show2dArray(int[,] array) 
{ 
    for(int i =0; i < array.GetLength(0); i++ ) 
    { 
        for(int j=0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
    Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 
 
int Numbers(int[,] array) 
{   int sum =0; 
      for(int i=0; i < array.GetLength(0); i++) 
      { 
            sum += array[i,i]; 
      } 
    return sum; 
} 
 
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
Numbers(myArray); 
Console.WriteLine(Numbers(myArray));*/

/*Задача 47. Задайте двумерный массив размером m×n, заполненный
 случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

/*double [,] GreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passlble value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passlble value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double [rows, colums];
         for(int i = 0; i < rows; i++)
         {
            for(int j = 0; j < colums; j++)
                array[i,j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()),2);
         }
    return array;
}    

void Show2dArray(double[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");
            
         Console.WriteLine();

    }
    Console.WriteLine();
}


 
double[,] myArray = GreateRandom2dArray();
 Show2dArray(myArray);*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в
 двумерном массиве, и возвращает значение этого элемента или же указание, 
 что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет*/

int[,] CreateRandom2dArray() 
{ 
    Console.Write("Input a number of rows: "); 
    int rows= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a number of columns: "); 
    int columns= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a min possible value: "); 
    int minValue= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input a max possible value: "); 
    int maxValue= Convert.ToInt32(Console.ReadLine()); 
 
 
    int[,] array = new int[rows, columns]; // Выделение памяти для двумерного массива 
 
    for(int i=0; i < rows; i++) 
        for(int j=0; j < columns; j++) 
            array[i,j] = new Random().Next(minValue, maxValue + 1);  
     
    return array; 
} 
 
void Show2dArray(int[,] array) 
{ 
    for(int i =0; i < array.GetLength(0); i++ ) 
    { 
        for(int j=0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
    Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 
 
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
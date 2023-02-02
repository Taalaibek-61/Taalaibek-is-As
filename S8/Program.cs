// Задайте двумерный массив. Напишите программу, которая поменяет местами 
//первую и последнюю строку массива.


/*int[,] CreateRandom2dArray()
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
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return array;
}
void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}
void ChangeRows(int[,] array, int row1, int row2)
{
  if (row1 >= 0 && row1 < array.GetLength(0) 
      && row2 >=0 && row2 < array.GetLength(0) 
      && row1 != row2)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          int temp = array[row1, j];
          array[row1, j] = array[row2, j];
          array[row2, j] = temp;
        }
      }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Input a number of first row: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of second row: ");
int r2 = Convert.ToInt32(Console.ReadLine());
ChangeRows(myArray, r1, r2);
Show2dArray(myArray);*/


// Задайте двумерный массив. Напишите программу, которая заменяет строки на 
//столбцы.


/*int[,] CreateRandom2dArray()
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
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return array;
}
void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}
void ChangeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0) - 1; i++)
  {
    for (int j = i + 1; j < array.GetLength(1); j++)
    {
      int temp = array[i, j];
      array[i, j] = array[j, i];
      array[j, i] = temp;
    }
  }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ChangeArray(myArray);
Show2dArray(myArray);*/


// Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.


/*int[,] CreateRandom2dArray()
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

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return array;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}


int[] MinElement(int[,] array)
{

  int minrow = 0;
  int mincol = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 1; j < array.GetLength(1); j++)
    {
      if (array[i, j] < array[minrow, mincol])
      {
        minrow = i;
        mincol = j;
      }
    }
  }
  int[] indexes = {minrow, mincol};
  return indexes;
}

int[,] NewArray(int[,] array, int[] indexes)
{
  int[,] massiv = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

  for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
  {
    if (indexes[0] == i) 
    {
      x--;
      continue;
    }
    else 
      for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
      {
        if (indexes[1] == j)
        {
          y--;
          continue;
        }
        else {
          massiv[x, y] = array[i, j];
        }
      }
  }
  return massiv;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Show2dArray(NewArray(myArray, MinElement(myArray)));*/

/*Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
int[] AverageInRows (int[,] array)
  {
  int[] average = new int[array.GetLength(0)];

     for(int j = 0; j < array.GetLength(1); j++)
     {
        

         for(int i = 0; i < array.GetLength(0); i++)
         {
         int max position =i;
         for(int m = 0; m < array.GetLength(0); m++)
               {
                 if(array[m] > max [position])  max position = m;
          
               }
               int temperary = array[i];
               array[i] = array max[position];
               array max[position] = temperary;

         }     
     }        
     

     return array;
 }
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray);
 AverageInRows (myArray);
 Show2dArray(AverageInRows );



/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3
int [,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер
 строки с наименьшей суммой элементов: 1 строка*/

 /*int [,] CreateRandom2dArray()
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

double[] AverageInColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            average[j] += array[i,j];
        average[j] = Math.Round((average[j] / array.GetLength(0)),2);
    }
    
    return average;
}

void ShowArray(double[] average)
{
    for(int i = 0; i < average.Length; i++)
        Console.Write(average[i] + " ");
    Console.WriteLine();
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] myAverage = AverageInColumns(myArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
ShowArray(myAverage);*/

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
}*/
/*double[] MethodD(int[,] array) 
{
    double[]aver = new double[array. GetLength(1)];
  
      for(int i=0; i < array.GetLength(0);i++) 
       
      { 
        for(int j=0; j < array.GetLength(1);j++)
            aver[i] += array[i,j];
         aver[i] = Math.Round((aver[i] / array.GetLength(1)),2);
      } 
      return aver;
}
void ShowArray (double[] aver)
{
for(int i=0; i < aver.GetLength(0);i++)
    Console.Write(aver[i]+ " ");
Console.WriteLine(); 
} 

double Min(double[] array) 
{ 
    
    double min = array[0];
     double numRow = 0;
    for(int i = 0; i < array.Length; i++)
    {
        
        
        if(array[i] <= min) min = array[i];
               numRow = i +1;
    }
    
    return numRow; 
}*/ 
//int [,] myArray = CreateRandom2dArray(); 
//Show2dArray(myArray); 
/*double[]myAver = MethodD(myArray);
Console.WriteLine("Среднее арифметическое значение каждого строки"); 
 ShowArray (myAver);*/
//  int result = MinRow(myArray);
//Console.WriteLine( "Номер строки с наименьшей суммой элементов"   + result);
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


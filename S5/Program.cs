/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] GreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 999 + 1);
    return array;
}
    void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int GetNumOfEven(int[] array)
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
       if(array[i] % 2  == 0)
         a = a + 1;


    return a;
}
Console.Write("Input a length of array: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min passible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max passlble value: ");
 int max = Convert.ToInt32(Console.ReadLine());

int[] newArray =GreateRandomArray(m, min, max);
 ShowArray(newArray);
 
 int result = GetNumOfEven(newArray);
 Console.WriteLine("Number of even numbers " + result); 


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] GreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}
    void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int GetSumOfAdd(int[] array)
{
    int a = 0;
    for(int i = 1; i < array.Length; i = i + 2)
       
         a = a + array[i];


    return a;
}
Console.Write("Input a length of array: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min passible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max passlble value: ");
 int max = Convert.ToInt32(Console.ReadLine());

int[] newArray =GreateRandomArray(m, min, max);
 ShowArray(newArray);
 
 int result = GetSumOfAdd(newArray);
 Console.WriteLine("Sum " + result); 


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

    
        
 
 double[] GreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()),4);
        return array;
}
    void ShowArray(double[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
double DiffMaxMin(double[] array) 
{ 
    double diff = 0;
    double max =array [0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array[i] >= max) max = array[i];
        if(array[i] <= min) min = array[i];

    }
    diff = max - min;
    return diff; 
} 
Console.Clear();                                                                                                            
 Console.Write("Input a length of array: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min passible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max passlble value: ");
 int max = Convert.ToInt32(Console.ReadLine());   
 
 double[] newArray = GreateRandomArray(m, min, max);
 ShowArray(newArray);
 double result = Math.Round(DiffMaxMin(newArray),4);
 Console.WriteLine("Difference maximum and minimum elements of the array is" + result);



  
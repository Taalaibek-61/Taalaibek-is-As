/*int[] GreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}*/

/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        Console.Write($"Input an {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}*/
/*int GetSumOfNegative(int[] array)
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
       if(array[i] > 0)
         a = a + 1;


    return a;
}*/
/*Console.Write("Input a length of array: ");
 int length = Convert.ToInt32(Console.ReadLine());*/

/*Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());*/

/*int[] newArray = CreateArray(length);
ShowArray(newArray);*/
/*int result = GetSumOfNegative(newArray);
 Console.WriteLine("Number of negative elements is " + result);*/


/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
/*int GetSumOfNegative(int[] array)
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
       if(array[i] < 0)
         a = a + 1;


    return a;
}*/
 /*Console.Write("Input a length of array: ");
 int length = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min passible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max passlble value: ");
 int max = Convert.ToInt32(Console.ReadLine());*/

 /*int[] newArray =GreateRandomArray(int size, int minValue, int maxValue);
 ShowArray(newArray);
 int result = GetSumOfNegative(newArray);
 Console.WriteLine("Number of negative elements is " + result);*/
 
 int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        Console.Write($"Input an {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.Write("Input a length of array: ");
 int length = Convert.ToInt32(Console.ReadLine());
 int[] newArray = CreateArray(length);
ShowArray(newArray);
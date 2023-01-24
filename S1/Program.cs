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
}
int GetSumOfNegative(int[] array)
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
       if(array[i] > 0)
         a = a + 1;


    return a;
}
Console.Write("Input a length of array: ");
 int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);
ShowArray(newArray);
int result = GetSumOfNegative(newArray);
 Console.WriteLine("Количество положительных чисел " + result);*/


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
}
int GetSumOfNegative(int[] array)
{
    int a = 0;
    for(int i = 0; i < array.Length; i++)
       if(array[i] > 0)
         a = a + 1;


    return a;
}
Console.Write("Input a length of array: ");
 int length = Convert.ToInt32(Console.ReadLine());
 int[] newArray = CreateArray(length);
ShowArray(newArray);
int n = GetSumOfNegative(newArray);
Console.WriteLine("Количество положительных чисел "  п);*/


/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int MethodA( int numbers)
{
    int a = 0;
    

    
    Console.WriteLine("Input a number ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    
       if(numbers  > 0)
         a = a + 1;


    return a;
}
//Console.WriteLine("Input a number ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input a number ");
//int m = Convert.ToInt32(Console.ReadLine());

int m = 4;
Console.WriteLine("Input a num ");
int N = Convert.ToInt32(Console.ReadLine());
 int result = MethodA(m);
 for(int i = 0; i < N; i++)
Console.WriteLine("Количество положительных элементов " + result);

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
}
Console.Write("Input a length of array: ");
 int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);
ShowArray(newArray);*/
// Instantiate random number generator
        /*Random rand = new Random();
  
        // Instantiate an array of double
        double[] a = new double[10];
  
        // Store random floating point 
        // numbers in the array
        for (int i = 0; i < 10; i++)
            a[i] = rand.NextDouble();
  
        // Print 10 random floating point numbers
        Console.WriteLine("Printing 10 random "+
                      "floating point numbers");
  
        for (int i = 0; i < 10; i++)
            Console.WriteLine("{0} -> {1}", i, a[i]);*/
            // Instantiate random number generator
      /*  Random rand = new Random();
  
        // Instantiate an array of double
        double[] a = new double[10];
  
        
        for (int j = 0; j < 10; j++)
            a[j] = rand.NextDouble();*/
  
  /*Console.Write("Input a length of array: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min passible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max passlble value: ");
 int max = Convert.ToInt32(Console.ReadLine()); 

 
 int[] newArray =GreateRandomArray(m, min, max);
 ShowArray(newArray);*/
        // Print 10 random floating point numbers

       /* Console.WriteLine("Printing 10 random "+
                      "floating point numbers");
  
        for (int i = 0; i < 10; i++)
            Console.WriteLine("{0} -> {1}", i, a[i]);
    
 Double function(Double [][] array) 
 {

    Double summ = 0.0;
    for(int i = 0; i < 10; i++)
       for(int j = 0; j<10; j++) 
    summ = summ  + array[i] + a[j];*/

    /*for (Double[] anArray : array) 
    {
        summ += Stream
                .of(anArray)
                .mapToDouble(s -> s)
                .sum();
    }
    return summ;
}*/
  
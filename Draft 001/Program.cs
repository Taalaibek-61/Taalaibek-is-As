﻿/*Console.Write("Введите число" + " " );
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число" + " " );
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число" + " " );
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число" + " " );
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(a, b, n, m  );*/

/*Доброе время суток, нужна помощь! Нужно создать массив из 6 элементов в приделах(0,11) которые не будут повторяться. Вот то что я реализовал. Но понимаю 
что это както не првильно и можно обойтись без goto. Жду ваших предложений.*/


//Создаем random
Random r = new Random();
   
//Создаем массив на нужноее нам кол-во элементов   
int[] arr = new int[count];
   
//Запускаем цикл который будет присваивать значения массиву
for (int i = 0; i < arr.Length; i++) 
{
 //Создаем именнованый оператор а и присваиваем элементу массива случайное число
 a: arr[i] = r.Next(0, 11);
    
 //Пропускаем 0 элемент, так как его не счем пока сравнивать
 if(i > 0)
 {
  //Запускаем цикл который будет сравнивать элементы массива
  for(int j = 0; j < i; j++)
  {
   //Если находим одинаковые
   if(arr[j] == arr[i])
   {
    // то перенаправляемся по оператору goto в а:
    goto a;
   }
   //На выходе мы получим массив без повторяющихся елементов
  }
 }
}
   
//Выводим массив   
foreach (var item in arr) 
{
 Console.WriteLine(item);
}
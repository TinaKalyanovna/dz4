
// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
/*

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int sum = a;


for (int i = 1; i < b; i++)
{
  sum = sum * a;
}
Console.WriteLine("A в натуральной степени B: " + sum);

*/



/*

// Задача 27: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10  //

// // 9012 -> 12

Console.Write("Введитечисло: ");
var number = Convert.ToInt32(Console.ReadLine());
var sum = 0;
 while (number > 0 )
 {
    sum += number % 10;
    number /=10;
 }
 Console.WriteLine(sum);


*/




// Задача 29: Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


/*

Console.Write("Колличество элементов массива:\t ");
//int[] array = {1,2,5,19,6,1,33};
//int[] length = int.Parse(Console.ReadLine());
int[] array = new int[8];

 for (int i = 0; i < array.Length; i++)
 {
     Console.Write($"Введите элемент массива {i}: \t");
     array[i] = int.Parse(Console.ReadLine());
 }
 Console.WriteLine( "Вывод массива:   " +  array.Length);


 */
// // while (true)
// // {
// //     Console.Write("Введите число: , для остановки введите букву 'q'");
// //     string text = Console.ReadLine();
// //     if (int.TryParse(text, out int number))
// //     {
// //         Console.WriteLine("Вы ввели число {0}", number);
// //     }
// //     if(text =="q"){
// //        break;
// // }
// // }
// // // Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[]n = new int[5];
// Random random = new Random();
// int count = 0;
// for (int i = 0; i < n.Length; i++)
// {
//     n[i] = new Random().Next(100,1000);
//     Console.WriteLine(n[i] );
//     if(n[i]%2==0){
//         count++;

//     }


// }
// Console.WriteLine($"Количество четных чисел равно {count}");
// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// using System.Globalization;

int[] number = new int[] { 9, 8, 7, 6, 5, 4 };
int temp;
Console.Write("Исходный код: ");
foreach (int item in number)
{
  Console.Write(item);
}
Console.WriteLine();
for (int i = 0; i < number.Length / 2; i++)
{
  temp = number[i];
  number[i] = number[number.Length - 1 - i];
  number[number.Length - 1 - i] = temp;
 
}
Console.Write("Перевернутый массив: ");
foreach (int item in number)
{
  Console.Write(item);
}


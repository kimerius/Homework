// // // // // // // while (true)
// // // // // // // {
// // // // // // //     Console.Write("Введите число: , для остановки введите букву 'q'");
// // // // // // //     string text = Console.ReadLine();
// // // // // // //     if (int.TryParse(text, out int number))
// // // // // // //     {
// // // // // // //         Console.WriteLine("Вы ввели число {0}", number);
// // // // // // //     }
// // // // // // //     if(text =="q"){
// // // // // // //        break;
// // // // // // // }
// // // // // // // }
// // // // // // // // Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // // // // // int[]n = new int[5];
// // // // // // Random random = new Random();
// // // // // // int count = 0;
// // // // // // for (int i = 0; i < n.Length; i++)
// // // // // // {
// // // // // //     n[i] = new Random().Next(100,1000);
// // // // // //     Console.WriteLine(n[i] );
// // // // // //     if(n[i]%2==0){
// // // // // //         count++;

// // // // // //     }


// // // // // // }
// // // // // // Console.WriteLine($"Количество четных чисел равно {count}");
// // // // // // Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// // // // // // using System.Globalization;

// // // // // int[] number = new int[] { 9, 8, 7, 6, 5, 4 };
// // // // // int temp;
// // // // // Console.Write("Исходный код: ");
// // // // // foreach (int item in number)
// // // // // {
// // // // //   Console.Write(item);
// // // // // }
// // // // // Console.WriteLine();
// // // // // for (int i = 0; i < number.Length / 2; i++)
// // // // // {
// // // // //   temp = number[i];
// // // // //   number[i] = number[number.Length - 1 - i];
// // // // //   number[number.Length - 1 - i] = temp;

// // // // // }
// // // // // Console.Write("Перевернутый массив: ");
// // // // // foreach (int item in number)
// // // // // {
// // // // //   Console.Write(item);
// // // // // }

// // // // using System;

// // // // //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// // // // class UserInputToCompileForTest
// // // // {
// // // //     // Печать массива
// // // //     public static void PrintArray(int[,] array)
// // // //     {
// // // //         //Напишите свое решение здесь
// // // //     }

// // // // // Обмен первой с последней строкой
// // // //     public static int[,] SwapFirstLastRows(int[,] array)
// // // //     {

// // // //         for (int i = 0; i < array.GetLength(0); i++)
// // // //         {
// // // //           for (int j = 0; j < array.GetLength(1); j++)
// // // //           {

// // // //             int temp = array[i];
// // // //             array[i] = array[j];
// // // //             array[j] = temp;


// // // //           }
// // // //         }
// // // //         return array;
// // // //     }

// // // // // Обмен элементами массива
// // // //     public static void SwapItems(int[,] array, int i)
// // // //     {
// // // //        //Напишите свое решение здесь
// // // //     }

// // // //     public static void PrintResult(int[,] numbers)
// // // //     {
// // // //         int[,] arr = SwapFirstLastRows(array);
// // // //     }
// // // // }

// // // // //Не удаляйте и не меняйте класс Answer!
// // // // class Answer
// // // // {
// // // //     public static void Main(string[] args)
// // // //     {
// // // //         int[,] numbers;

// // // //         if (args.Length >= 1)
// // // //         {
// // // //             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
// // // //             string[] rows = args[0].Split(',');

// // // //             int rowCount = rows.Length;
// // // //             int colCount = rows[0].Trim().Split(' ').Length;

// // // //             numbers = new int[rowCount, colCount];

// // // //             for (int i = 0; i < rowCount; i++)
// // // //             {
// // // //                 string[] rowElements = rows[i].Trim().Split(' ');

// // // //                 for (int j = 0; j < colCount; j++)
// // // //                 {
// // // //                     if (int.TryParse(rowElements[j], out int result))
// // // //                     {
// // // //                         numbers[i, j] = result;
// // // //                     }
// // // //                     else
// // // //                     {
// // // //                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
// // // //                         return;
// // // //                     }
// // // //                 }
// // // //             }
// // // //         }
// // // //         else
// // // //         {
// // // //             // Если аргументов на входе нет, используем примерный массив
// // // //             numbers = new int[,]
// // // //             {
// // // //                 {1, 2, 3, 4},
// // // //                 {5, 6, 7, 8},
// // // //                 {9, 10, 11, 12}
// // // //             };
// // // //         }
// // // //         UserInputToCompileForTest.PrintResult(numbers);
// // // //     }
// // // // }
// // // string CharOfString(char[] arr)
// // // {
// // //   string st = "";
// // //   foreach (char item in arr)
// // //   {
// // //     st += item;
// // //   }
// // //   return st;
// // // }
// // // char[] arr = new char[] { 'a', 'b', 'c', 'd' };
// // // Console.WriteLine(CharOfString(arr));
// // char[] StringOfChar(string str)
// // {
// //   char[] mas = new char[str.Length];
// //   for (int i = 0; i < mas.Length; i++)
// //   {
// //     mas[i] = str[i];
// //   }
// //   return mas;
// // }
// // void PrintMas(char[] arr){
// //   foreach (var item in arr)
// //   {
// //     Console.Write($"{item}  ");
// //   }
// //   Console.WriteLine();
// // }
// // string st = Console.ReadLine()!;
// // PrintMas(StringOfChar(st));


// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.
string CharOfString(char[,] arr)
{
  string st = "";
  foreach (char item in arr)
  {
    st += item;
  }
  return st;
}
char[,] arr = new char[,]{
  {'H','e','l','l','o'},
  {'W','o','r','l','d'}
};
Console.WriteLine(CharOfString(arr ));

//   Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
//  в которой все заглавные буквы заменены на строчные.

void PrintToLower(string[] args)
{
  string a = ("HeLlO WoRlD");
  Console.WriteLine(a.ToLower());

}

PrintToLower(args);


// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
public class Task3
{
public static void Main(string[] args)
{
// Входная строка для проверки
string input = "шалаш";
// Вызов метода для проверки, является ли строка палиндромом 
bool isPalindrome = IsPalindrome(input);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
public static bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}
}





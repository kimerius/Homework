// Задание 1
// using System;

// class Program
// {
//     static void PrintNumbers(int m, int n)
//     {
//         if (m <= n)
//         {
//             Console.Write(m + " ");
//             PrintNumbers(m + 1, n);
//         }

//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите значение M:");
//         int m = int.Parse(Console.ReadLine()!);

//         Console.WriteLine("Введите значение N:");
//         int n = int.Parse(Console.ReadLine()!);

//         Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
//         PrintNumbers(m, n);
//     }
// }


// Задание 2 Аккермана.
// using System;

// class Program{


// static int Ackermann(int m, int n)
// {
//   if (m == 0)
  
//     return n + 1;
  
//   else if (m > 0 && n == 0)
  
//     return Ackermann(m - 1, 1);

  
//   else
  
//     return Ackermann(m - 1, Ackermann(m, n - 1));


// }
// static void Main (string [] args){
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine()!);
// int m = Convert.ToInt32(Console.ReadLine()!);
// int result = Ackermann(m, n);
// Console.WriteLine(result);
// }
// }
   


  //  Задание 3.

  using System;

class Program
{
    static void PrintNumbers(int [] m, int index)
    {
        if (index>=0)
        {
            Console.WriteLine(m[index]);
            PrintNumbers(m, index -1);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int [] m = {1,2,3,4,5};
        PrintNumbers(m, m.Length-1);
    }
}

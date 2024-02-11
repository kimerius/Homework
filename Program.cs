// string Len(int stop, int start = 1)
// {
// if(start == stop) return Convert.ToString(start);
// return start + " " + Len(stop, start + 1);
// }


// Console.WriteLine("Ввеите число");
// int n = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(Len(n));

void Len(int num)
{
if (num == 0) return;
Len(num - 1);
Console.Write($"{num} ");
}


Console.WriteLine("Ввеите число");
int n = Convert.ToInt32(Console.ReadLine()!);
Len(n);
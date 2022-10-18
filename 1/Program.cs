// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Number: ");
int n = Convert.ToInt32(Console.ReadLine());  
int end = 2;
Print(n, end);
Console.Write(1);
void Print(int n, int end)

{
    if ( end > n ) return;
    Print(n, end + 1);
  Console.Write(end + ", ");
} 


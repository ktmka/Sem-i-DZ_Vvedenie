// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.WriteLine("add number");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(n, 1));

// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }

//--------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("add number M");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number N");
// int n = int.Parse(Console.ReadLine()!);
// if (n < m){
//     int temp = m;
//     m = n;
//     n = temp;
// }
// if (n == m){
//     Console.WriteLine($"Числа равны, сумма {n} + {n} = {n * 2}");
// }

// Console.WriteLine(PrintNumbers(m, n));  // m , n входят в промежуток

// int PrintNumbers(int start, int end){
//     if (start == end) return start;
//     return (start + PrintNumbers(start + 1, end));
// }
    
//----------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.WriteLine("add number M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("add number N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FunAkkerman(m, n));

int FunAkkerman(int a, int b){
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return FunAkkerman(a - 1, 1);
    else return FunAkkerman(a - 1, FunAkkerman(a, b - 1));
}




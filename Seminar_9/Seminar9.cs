// int Factorial(int n){
//     if (n == 1) return 1;
//     return n * Factorial(n - 1);
// }


// Console.WriteLine("add number");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(1, n));

// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }



// Console.WriteLine("add number M");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number N");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(m + 1, n - 1));

// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }


// сумма цифр числа
// Console.WriteLine("add number");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SumNumbers(m));

// int SumNumbers(int limit){
//     int sum = limit % 10;
  
//     if (limit < 1) return limit;
//     else{
//     return sum + (SumNumbers (limit / 10));
//     }
// }

// Вариант2
// сумма цифр числа
// Console.WriteLine("add number");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SumNumbers(m));

// int SumNumbers(int limit){
//     if (limit < 1) return limit;
//     else{
//     return limit % 10 + (SumNumbers (limit / 10));
//     }
// }

// Возвести M в степень N
Console.WriteLine("add number M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("add number N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(PowNumbers(m, n));

int PowNumbers(int number, int pow){
    if (pow == 0) return 1;
    if (pow <= 1) return number;
    else {
        return (number * PowNumbers(number, pow - 1));
    }
}

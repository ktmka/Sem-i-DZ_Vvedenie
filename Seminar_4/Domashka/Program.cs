// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// Console.WriteLine( "Введите первое число");
// int n1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine( "Введите второе число");
// int n2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {n1} в степени {n2} = {GetPow(n1, n2)}");

// int GetPow(int a, int b){       // Метод
//     int pow = a;
//     for (int i = 1; i < b; i++){
//         pow = pow * a;
//     }
//     return pow;
// }

// ---------------------------------------------------------------------------------
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Вариант1
Console.WriteLine( "Введите число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {n} = {GetSum(n)}");

int GetSum(int a){       
    string x = a.ToString();
    int length = x.Length;
    int sum = 0;
    for (int i = 0; i < length; i++){
        sum = sum + a%10;
        a = a/10;
    }
    return sum;
}


// Вариант 2, с конвертацией string -> int32. Не работает? на строке int x = Convert.ToInt32(a[i]); 
// Console.WriteLine( "Введите число");
// string n = (Console.ReadLine()!);    
// Console.WriteLine($"Сумма цифр в числе {n} = {GetSum(n)}");

// int GetSum(string a){       
//     int sum = 0;
//     int length = a.Length;
//     for (int i = 0; i < length; i++){
//         int x = (Convert.ToInt32(a[i]));
//         Console.WriteLine(x);
//         sum = sum + x;
//     }
//     return sum;
// }




// ----------------------------------------------------------------------------
// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Вариант 1. Массив из N элементов с рандомными значениями (взяла от 0 до 100)

// Console.WriteLine( "Введите желаемое число элементов в массиве");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = RandomArray(x);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] RandomArray(int size){
//     int[] a = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         a[i] = new Random().Next(101);
//     }
//     return a;
// }


// Вариант 2. Программа спрашивает нужное кол-во элементов, затем считывает N чисел 
//и создает из них массив 

// string RandomArray(){
//     Console.WriteLine( "Введите желаемое число элементов в массиве");
//     int size = int.Parse(Console.ReadLine()!);
//     int[] a = new int[size];
//     int x = 0;
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine( "введите число");
//         x = int.Parse(Console.ReadLine()!);
//         a[i] = x;
//     }
//     return ($"[{String.Join(", ", a)}]");
// }

// Console.WriteLine(RandomArray());

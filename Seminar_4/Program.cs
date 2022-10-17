// Программа выводит сумму чисел от 1 до А
// Console.WriteLine( "Введите число");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSum(A)}");

// //Создаем метод
// int GetSum(int limit){
//     int sum = 0;
//     for (int i = 1; i <= limit; i++){
//         sum = sum + i;
//     }
//     return sum;
// }
//----------------------------------------------------------------
// Программа выводит количество цифр в числе
// Console.WriteLine( "Введите число");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Кол-во цифр в числе  = {GetNum(B)}");

// // Создаем метод
// int GetNum(int n){
//     int i = 0;
//     if (n > 0){
//         while (n > 0)
//         {
//             while (i < n)
//             {
//                 n = n/10;
//                 i ++;
//             }
//         }
//     return i;  
//     }
//     return 1;  
//     }
// Ну и капец!!!


// Вариант со строкой - лучше
// Console.WriteLine( "Введите число");
// string h = (Console.ReadLine()!);
// Console.WriteLine($"Количество цифр в {h} = {GetNum2(h)}");

// //Создаем метод
// int GetNum2(string a){
//     int length = a.Length;
//     return length;
// }

// ----------------------------------------------------------
// Программа выводит произведение чисел от 1 до n
// Console.WriteLine( "Введите число");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {n} = {GetPr(n)}");

// //Создаем метод
// int GetPr(int a){
//     int proizv = 1;
//     for (int i = 1; i <= a; i++){
//         proizv = proizv * i;
//     }
//     return proizv;
// }

// ---------------------------------------------------------------
// Программа выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке
// int[] a = {0,0,0,0,0,0,0,0};
// void RandomArray(int[] array)     // Метод для вывода массива последовательно по одному значению
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {   array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]} ");      // Вывод в одну строку
//     }
//     Console.Write(" ");                   // Пустая строка для разделения
// }
// RandomArray(a);

//Вариант2
// int[] a = new int[8];
// void RandomArray(int size){
//     for (int i = 0; i < size; i++)
//     {
//         a [i] = new Random().Next(0, 2);
//     }
// }
// RandomArray(a.Length);
// Console.WriteLine(String.Join(", ", a));

// Вариант 3
int[] array = RandomArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] RandomArray(int size){
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(2);
    }
    return a;
}
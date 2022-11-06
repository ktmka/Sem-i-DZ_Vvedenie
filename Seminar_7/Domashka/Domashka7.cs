// Задача 47. Задайте 2х мерный массив размером m * n, заполненный случайными веществ.числами
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, -10, 10);
// PrintArray(array);

// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double [,] result = new double[m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().NextDouble();
//             result[i, j] = result[i, j] * (maxValue - minValue) + minValue;

//         }
//     }
//     return result;
// }

// void PrintArray(double[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){     // строки
//         for (int j = 0; j < array.GetLength(1); j++){   // столбцы
//             Console.Write($"{Math.Round(array[i, j], 1)}; ");
//         }
//         Console.WriteLine();
//     }
// }

// PS: Идея решения взята отсюда https://stackoverflow.com/questions/20785502/c-sharp-generating-random-int-number-range
/* public static class RandomExtensions    
// {
//     public static int NextDouble(this Random RandGenerator, int MinValue, int MaxValue)
//     {
//         return RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue;
//     }
// }*/


// ----------------------------------------------------------------
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.*/
// Console.WriteLine("укажите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите номер строки");
// int numI = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите номер столбца");
// int numJ = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);  // создаем массив

// PrintArray(array);                                  // выводим массив

// Console.WriteLine(FindPosElement(numI, numJ, array)); // ищем элемент в этом массиве

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int [,] result = new int[m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){     // строки
//         for (int j = 0; j < array.GetLength(1); j++){   // столбцы
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// string FindPosElement(int numI, int numJ, int[,] array){
//     if (numI < array.GetLength(0) && numJ < array.GetLength(1)){
//         int temp = 0;
//         for (int i = 0; i < array.GetLength(0); i++){
//             for (int j = 0; j < array.GetLength(1); j++){
//                 if (i == numI && j == numJ){
//                     temp = array[i, j];
//                 }  
//             }
        
//         }
//         return $"элемент с индексом [{numI}, {numJ}] имеет значение {temp}";
//     }
            
//     else    return $"позиции [{numI},{numJ}] в массиве нет";
// }
    

//----------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SredColumns(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int [,] result = new int[m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){     // строки
//         for (int j = 0; j < array.GetLength(1); j++){   // столбцы
//             Console.Write($"{array[i, j]}, ");
//         }
//         Console.WriteLine();
//     }
// }

// void SredColumns(int[,] array){
//     int count = 0;                                 // указатель номера столбца
//     for (int j = 0; j < array.GetLength(0); j++){  // перебор столбцов
//         double sum = 0;
//         count++;
//         for (int i = 0; i < array.GetLength(1); i++){  // перебор строк
//             sum = sum + array[i, j];
//         }
//         double sred = sum/array.GetLength(1);
//         Console.WriteLine($"в столбце {count} сред.арифм. = {Math.Round(sred, 1)},  ");
//     }
// } 
// Задайте 2х мерный массив размером m * n (рандомные значения)
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

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

// ---------------------------------------------
// Задайте 2х мерный массив размером m * n (каждое значение это сумма его индексов i + j)
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int [,] result = new int[m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = i + j;
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
// ------------------------------------------------------------


// Задайте 2х мерный массив размером m * n и посчитайте среднее арифм.угловых цифр (4 угла) 
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 12);
// PrintArray(array);
// Console.WriteLine($"среднее арифметическое 4х углов = {SumArray(array)}");

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

// int SumArray(int[,] array){
//     int sum = (array[0, 0] + array[0, array.GetLength(0) -1] + array[array.GetLength(0) -1, (array.GetLength(1) -1)] + array[array.GetLength(1) -1, 0])/4;
//     return sum;
// }

// ПОДУМАТЬ!! Над вторым вариантом и сдать в ДЗ
// Задайте 2х мерный массив размером m * n и посчитайте среднее арифм.нескольких угловых цифр (для каждого угла) 
// Черновик
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 12);
// PrintArray(array);
// Console.WriteLine($"среднее арифметическое 4х углов = {SumArray(array)}");

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

// int SumArray(int[,] array){
//     int sum = (array[0, 0] + array[0, array.GetLength(0) -1] + array[array.GetLength(0) -1, (array.GetLength(1) -1)] + array[array.GetLength(1) -1, 0])/4;
//     return sum;
// }

// -----------------------------------------------

// В массиве найти элементы, 
//у которых оба индекса четные (в т.ч.0) и заменить эти элементы на их квадраты
// Console.WriteLine("add number of rows");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add number of columns");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
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

// Метод1 - перезаписи в одном массиве
// EvenReplace(array);
// PrintArray(array);
// void EvenReplace(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){   
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i % 2 == 0 && j % 2 == 0){
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }



// Метод2 - копирования в другой массив
// Возвращал Int32 при попытке вывести результ.массив через Console.Writeline
// Выводит массив через метод PrintArray
// int[,] res = EvenReplace(array);
// PrintArray(res);

// int[,] EvenReplace(int[,] array){
//     int [,] result = new int[array.GetLength(0),array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i % 2 == 0 && j % 2 == 0){
//                 result[i, j] = array[i, j] * array[i, j];
//             }
//             else result[i, j] = array[i, j];
//         }
//     }
//     return result;
// }


// -----------------------------------------------------
// Сумма элементов, находящихся на главной диагонали массива 
// (на ней элементы имеют индексы 0,0; 1,1; 2,2; ...и т.д.)
Console.WriteLine("add number of rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("add number of columns");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"сумма элементов на глав.диагонали = {SumDiagon(array)}");


int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){     // строки
        for (int j = 0; j < array.GetLength(1); j++){   // столбцы
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int SumDiagon(int[,] array){
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){   // Метод подсчета суммы
        for (int j = 0; j < array.GetLength(1); j++){
            if (i == j){
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

// Сумма элементов, находящихся на обратной главной диагонали массива 
// (на ней элементы имеют индексы 0,0; 1,1; 2,2; ...и т.д.)
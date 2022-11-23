// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("укажите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("укажите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9);  // создаем и выводим массив 
PrintArray(array);  
Console.WriteLine();
DesсSortRows(array);       // сортируем и выводим массив
PrintArray(array);  

void DesсSortRows(int[,] array){                            
    for (int i = 0; i < array.GetLength(0); i++){  // перебор строк
        for (int j = 0; j < array.GetLength(1); j++){  // перебор столбцов 
            int k = j + 1;                             // + вариант k=1, возрастание k +=2 (но магические цифры)
            while (k < array.GetLength(1)){
                if (array [i, k] > array[i, j]){
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
                k++;
            }
        }
    }
} 

//--------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("укажите количество строк");
// int row = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int col = int.Parse(Console.ReadLine()!);

// int[,] array2 = GetArray(row, col, 0, 9);  // создаем и выводим массив 
// PrintArray(array2);  
// Console.WriteLine();

// if (array2.GetLength(0) == array2.GetLength(1)){
//     Console.WriteLine("Ошибка: в данной задаче матрицы не должны быть квадратными");
// }
// else{
//     MinRows(array2);
// }

// void MinRows(int[,] array){
//     int count = 0;   
//     int[] temp = new int[array.GetLength(0)];                             
//     for (int i = 0; i < array.GetLength(0); i++){  // перебор строк
//         int sum = 0;
//         count++;
//         for (int j = 0; j < array.GetLength(1); j++){  // перебор столбцов
//             sum = sum + array[i, j];
//         }
//         temp[count - 1] = sum;
//     }
    
//     int k = 0;
//     int min = temp[0];
//     int minK = 0;
    
//     while (k < temp.Length){
//         if (temp[k] < min){
//             min = temp[k];
//             minK = k;
//             k++;
//         }
//         else k++;
//     }
//     Console.WriteLine($"индекс минимальной строки [{minK}] / номер строки {minK + 1}");
// } 
// -------------------------------------------------------------------------------------

// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// (все элементы строки А умножаются на элементы столбца В)
// ab  X  ef  =  ae + bg    af + bh
// cd     gh     ce + dg    cf + dh
// Console.WriteLine("укажите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] arrayA = GetArray(columns, rows, 0, 9);  // создаем массив A
// int[,] arrayB = GetArray(rows, columns, 0, 9);  // создаем массив B 

// PrintArray(arrayA);  
// Console.WriteLine();
// PrintArray(arrayB);                                 // выводим массивы
// Console.WriteLine();


// if (arrayA.GetLength(1) != arrayB.GetLength(0)){
//     Console.WriteLine("Условие не выполнено, rows в A не равно columns в B");
// }
// else{
//     int [,] arr = ProdArrays(arrayA, arrayB);
//     PrintArray(arr);
// }

// int[,] ProdArrays(int[,] a, int[,] b){
//     int [,] result = new int[a.GetLength(0),b.GetLength(1)];  // создаем массив для записи
//     for (int i = 0; i < a.GetLength(0); i++){                 // задание ширины строки i в первой матрице A (умножается на B)
//         for (int j = 0; j < b.GetLength(1); j++){             // задание длины столбца j во второй матрице B (на которую уножается A)
//             for(int k = 0; k < a.GetLength(1);k++){           // перебор k столбцов A в пределах строки i, и k строк B в пределах столбца j
                        
//                 result[i, j] += + (a[i, k] * b[k, j]);
    
//                 }
//         }
//     }
//     return result;
// }

//------------------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. (двумерный)
// Console.WriteLine("укажите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetSpirArray(rows, columns, 10);  // заполняем массив 
// PrintArray(array);                                  // выводим массив

// int[,] GetSpirArray(int row, int col, int minValue){   // метод
//     int [,] result = new int[row,col];
//     int limit = row * col;
//     int count = 0;
//     while (count < limit){                        // ограничение количества циклов 
//         for (int j = count; j < col - count; j++){
//             int x = count;
//             if (result[x, j] == 0){
//                 minValue++;
//                 result[x, j] = minValue;
//             } 
//             else break;
//         }
//         for (int i = count + 1; i < row - count; i++){
//             int y = col - count -1;
//             if (result[i, y] == 0){
//                 minValue++;
//                 result[i, y] = minValue;
//             }
//             else break;
//         }
//         for (int j = col - count - 2; j > count - 1; j--){
//             int z = row - count - 1;
//             if (result[z, j] == 0){
//                 minValue++;
//                 result[z, j] = minValue;
//             }
//             else break;

//         }
//         for (int i = row - count -2; i > count; i--){
//             int h = count;
//             if (result[i, h] == 0){
//                 minValue++;
//                 result[i, h] = minValue;
//             }
//             else break;
//         }
//         count++;
//     }
//     return result;
// }

//----------------------------------------------------------------------------------------

//Задача с семинара 8. Отсортировать нечетные столбцы(смотрите по индексам) массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами
// Console.WriteLine("укажите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);  // создаем и выводим массив 
// Console.WriteLine("исходный массив:");
// PrintArray(array);  
// Console.WriteLine();
// AscSortRows(array);       // сортируем и выводим массив
// Console.WriteLine("отсортированный массив:");
// PrintArray(array); 

// void AscSortRows(int[,] array){                            
//     for (int j = 0; j < array.GetLength(1); j++){  // перебор строк
//         for (int i = 0; i < array.GetLength(0); i++){  // перебор столбцов 
//             int k = i + 1;                             
//             while (k < array.GetLength(1)){
//                 if (array [k, j] < array[i, j] && j % 2 != 0){
//                     int temp = array[i, j];
//                     array[i, j] = array[k, j];
//                     array[k, j] = temp;
//                 }
//                 k++;
//             }
//         }
//     }
// } 
//---------------------------------------------------------------------------
// Общие функции для двухмерных массивов
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
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


// ------------------------------------------------------------------
// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Console.WriteLine("укажите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество страниц");
// int pages = int.Parse(Console.ReadLine()!);

// int[,,] array = GetThreeDimArray(rows, columns, pages, 10, 99);  // создаем массив

// PrintThreeDimArray(array);                                       // выводим массив

// // Вариант1 (принят в ДЗ к семинару 7) . Создание массива с заполнением по убыванию (числа не повторяются)
// int[,,] GetThreeDimArray(int m, int n, int p, int minValue, int maxValue){
//     int [,,] result = new int[m, n, p];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             for (int k = 0; k < p; k++){
//                 result[i, j, k] = maxValue;
//                 maxValue--;
//             }
//         }
//     }
//     return result;
// }

// // Вариант2 Создание массива с заполнением Random и проверкой повторяемости
// int[,,] GetThreeDimArray(int m, int n, int p, int minValue, int maxValue){
//     int [,,] result = new int[m, n, p];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             int k = 0;
//             while (k < p){
//                 int temp = new Random().Next(minValue, maxValue + 1);
//                 int FindMatch(int[,,] array, int element){
//                     for (int i = 0; i < array.GetLength(0); i++){
//                         for (int j = 0; j < array.GetLength(1); j++){
//                             for (int k = 0; k < array.GetLength(2); k++){
//                                 if (array[i, j, k] == element) return 1;
//                             }
//                         }
//                     }
//                     return 0;
//                 }
//                 if (FindMatch(result, temp) == 1) continue;
//                 result[i, j, k] = temp;
//                 k++;
//             }
//         }
//     }
//     return result;
// }

// //Вывод трехмерного массива
// void PrintThreeDimArray(int[,,] array){
//     for (int i = 0; i < array.GetLength(0); i++){     // строки
//         for (int j = 0; j < array.GetLength(1); j++){   // столбцы
//             for (int k = 0; k < array.GetLength(2); k++){
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


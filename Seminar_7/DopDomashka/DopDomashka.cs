/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого 
элемента.*/
Console.WriteLine("укажите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("укажите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("укажите количество страниц");
int pages = int.Parse(Console.ReadLine()!);


int[,,] array = GetArray(rows, columns, pages, 10, 99);  // создаем массив

PrintArray(array);                                  // выводим массив

// // Вариант создания массива с заполнением Random (числа могут повторяться)
// int[,,] GetArray(int m, int n, int p, int minValue, int maxValue){
//     int [,,] result = new int[m, n, p];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             for (int k = 0; k < p; k++){
//                 result[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return result;
// }

// Вариант создания массива с заполнением по убыванию (числа не повторяются)
int[,,] GetArray(int m, int n, int p, int minValue, int maxValue){
    int [,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < p; k++){
                result[i, j, k] = maxValue;
                maxValue--;
            }
        }
    }
    return result;
}

//Вывод трехмерного массива
void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){     // строки
        for (int j = 0; j < array.GetLength(1); j++){   // столбцы
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// ----------------------------------------------------------














// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4


// ----???------   ПОКА НЕ РЕШЕНА


// Console.WriteLine("укажите количество строк");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("укажите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);  // создаем массив

// PrintArray(array);                                  // выводим массив


// int[,] GetArray(int m, int n, int minValue, int maxValue){


//     // i < length(1) -1, i++
//     // j < length(0) -1, j--
//     // i < length(1)-1, i --
//     // j < length (0), j++

//     int [,] result = new int[m,n];
//     int i = 0;
//     while (i < 1){
//         for (int j = 0; j < n; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = 1;
//         }
//     }
//     return result;


//     }
    
// }

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){     // строки
//         for (int j = 0; j < array.GetLength(1); j++){   // столбцы
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
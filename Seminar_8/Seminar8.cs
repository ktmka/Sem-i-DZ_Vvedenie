// Задать двумерный массив и поменять местами 1 и последнюю строку массива
Console.WriteLine("укажите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("укажите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9);  // создаем массив

PrintArray(array);                                  // выводим массив
Console.WriteLine();

if (array.GetLength(0) == array.GetLength(1)){
int [,] arr = ChangeArray2(array);
PrintArray(arr);
}
else Console.WriteLine("длина не равна ширине");

                              // выводим измененный массив


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

// void ChangeArray(int[,] array){
//     int i = 0;
//     int temp = 0;
//     for (int j = 0; j < array.GetLength(1); j++){   // столбцы
//         temp = array[i, j];
//         array[i, j] = array[array.GetLength(0)-1, j];
//         array[array.GetLength(0)-1, j] = temp;
//     }
// }


// ------------------------------------------------------------
// В двумерном массиве заменить строки на столбцы
// TO DO ??? (без создания второго массива)
// void ChangeArray2(int[,] array){
//     int temp = 0;
//     for (int collimit = array.GetLength(1) - 1; collimit > 0; collimit --){
//         for (int startrow = 0; startrow < array.GetLength(0); startrow++){
//             for (int i = startrow; i < array.GetLength(0); i++){
//                     for (int j = 0; j <= collimit; j++){
//                         temp = array[startrow, j];
//                         array[startrow, j] = array[i, collimit];
//                         array[i, collimit] = temp;
//                 }
                
//             }
//         }
    
//     }
    
// }


// с созданием второго массива
// int[,] ChangeArray2(int[,] array){
//     int [,] result = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             result[j, i] = array[i, j];
//         }
//     }
//     return result;
// }

//сортировка нечетных столбцов по возрастанию элементов
int[,] ChangeArray2(int[,] array){
    int [,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int j = 0; j < array.GetLength(0); j++){
        if (j % 2 == 1){
            for (int i = 0; i < array.GetLength(1); i++){
                int min = array[1, 1];
                if array
                




                result[i, j] = array[0, 0];
            }
        }
        else{
            for (int i = 0; i < array.GetLength(1); i++){
                result[i, j] = array[i, j];
            }
        }
    
    }
    return result;
}

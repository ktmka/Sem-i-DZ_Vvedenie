// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] arr = GetArr(10, 100, 999);
// Console.WriteLine($"В массиве: [{String.Join(", ", arr)}]");
// Console.WriteLine($"количество четных чисел = {evenCount(arr)}");

// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int evenCount(int[] a){
//     int count = 0;
//     foreach (var n in a){
//         if (n % 2 == 0){
//             count ++;
//         }  
//     }
//     return count;
// }

//-----------------------------------------------------------------------------
// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. 
// int[] arr = GetArr(10, -10, 10);
// Console.WriteLine($"В массиве: [{String.Join(", ", arr)}]");
// Console.WriteLine($"сумма элементов на нечетных позициях = {oddCount(arr)}");

// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int oddCount(int[] a){
//     int count = 0;
//     for (int i = 1; i < a.Length; i = i + 2){
//         count = count + a[i];
//     }
//     return count;
// }
//-------------------------------------------------------------------------------

// Задача 38. Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности
//Найдите разницу между максимальным и минимальным элементом массива. 
// int[] arr = GetArr(10, -1000, 1000);
// Console.WriteLine($"в массиве: [{String.Join(", ", arr)}]");
// Console.WriteLine($"разница между max и min = {diffArray(arr)}");

// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

//Вариант метода1 (while+if)
// int diffArray(int[] a){
//     int max = a[0];
//     int min = a[0];
//     int i = 1;
//     while (i < a.Length){
//         if (a[i] > max){
//             max = a[i];
//             i++;
//         }   
//         if (a[i] < min){
//             min = a[i];
//             i++;
//         }
//         else     i++;
//     }
//     int diff = max - min;
//     return diff;
// }

//Вариант метода2  (foreach + if)
// int diffArray(int[] a){
//     int max = a[0];
//     int min = a[0];
//     foreach (var n in a){
//         if (n > max){
//             max = n;
//         }  
//         if (n < min){
//             min = n;   
//         }
//     }
//     int difference = max - min;
//     return difference;
// }
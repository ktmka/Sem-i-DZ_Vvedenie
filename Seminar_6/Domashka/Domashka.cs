// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] array = new int[5];
Console.WriteLine("Ожилается 5 чисел. Введите число 1");
array[0] = int.Parse(Console.ReadLine()!);  
Console.WriteLine("Введите число 2");
array[1] = int.Parse(Console.ReadLine()!);  
Console.WriteLine("Введите число 3");
array[2] = int.Parse(Console.ReadLine()!);  
Console.WriteLine("Введите число 4");
array[3] = int.Parse(Console.ReadLine()!);  
Console.WriteLine("Введите число 5");
array[4] = int.Parse(Console.ReadLine()!);  

Console.WriteLine(String.Join(", ", array));
int res = PositivCalc(array);
Console.WriteLine($"количество положительных чисел в массиве = {res}");     

int PositivCalc(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0)   count ++;
    }
    return count;
}

// -------------------------------------------------------------------
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.WriteLine("Введите k1");
// float k1 = float.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите k2");
// float k2 = float.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите b1");
// float b1 = float.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите b2");
// float b2 = float.Parse(Console.ReadLine()!);


// Console.WriteLine(PointIntersection(k1, k2, b1, b2));

// string PointIntersection(float k1, float k2, float b1, float b2){
//     float x = (b2 - b1)/(k1 - k2);
//     float y = k1*x + b1;
//     float y1 = k1*x + b1;
//     float y2 = k2*x + b2;
//     if (y1 == y2 && k1 != k2){
//         return ($"({x}; {y}) --> точка пересечения");
//     }
//     if (k1 == k2)   return "Прямые параллельны";  

//     else   return "Прямые не имеют общих точек пересечения";   // на плоскости - если две прямые не имеют общих точек, то они параллельны
// }

// -----------------------------------------------------------------------------------------
// Доп.задача
/*Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100*/

// Console.WriteLine("Введите число");
// int x = int.Parse(Console.ReadLine()!);  // ввели число-ограничение

// int[] array = GetArr(10, 50, 100);
// Console.WriteLine(String.Join(" ", array));      // заполнили массив

// int res = GetMultiplication(array, x);
// Console.WriteLine(res);      // выполнили перемножение


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int GetMultiplication(int[] array, int limit){
//     int result = 1;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] < limit)   result = result * array[i];
//     }
//     return result;
// }
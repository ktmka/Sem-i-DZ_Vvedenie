// Создать массив 12 размерности, заполненный случайными числами из промежутка [-9, 9] включительно. 
// найти сумму + и - элементов массива
// int[] a = GetArr(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", a)}]");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int positivSum = 0;
// int negativSum = 0;

// for (int i = 0; i < a.Length; i++){
//     if (a[i] < 0){
//         negativSum = negativSum + a[i];
//     }
//     else{
//         positivSum = positivSum + a[i];
//     }
// }

// Console.WriteLine($"positivSum = {positivSum}, negativSum = {negativSum}");

// -------------------------------------------------------
// int[] a = GetArr(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", a)}]");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// for (int i = 0; i < a.Length; i++){
//     if (a[i] > 0){
//         a[i] = a[i] * (-1);
//     }
//     else{
//         a[i] = a[i];
//     }
// }

// Console.WriteLine($"[{String.Join(", ", a)}]");
// --------------------------------------------------------------------

// int[] a = GetArr(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", a)}]");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// for (int i = 0; i < a.Length; i++){
//     a[i] = a[i] * (-1);
//     }

// Console.WriteLine($"[{String.Join(", ", a)}]");
// --------------------------------------------------------------

// int[] a = GetArr(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", a)}]");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// Console.WriteLine("add number");
// int x = int.Parse(Console.ReadLine()!);
// for (int i = 0; i < a.Length; i++){
//     if (a[i] == x){
//         Console.WriteLine($"обнаружено число {a[i]}");
//     }
//     else {
//         Console.WriteLine($"не обнаружено число {a[i]}");
//     }
// }

//---------------------------------------------------------------
// int[] a = GetArr(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", a)}]");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// Console.WriteLine("add number");
// int x = int.Parse(Console.ReadLine()!);
// int count = 0;
// for (int i = 0; i < a.Length; i++){
//     if (a[i] == x){
//         count++;
//     }
// }
   
// if (count == 0){
//     Console.WriteLine($"не обнаружено число {x}");
// }
// else {
//     Console.WriteLine($"число {x} встречено {count} раз");
// }
// -----------------------------------------------------------------
// int[] a = GetArr(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", a)}]");
// Console.WriteLine("add number");
// int x = int.Parse(Console.ReadLine()!);
// if (FindElement(a, x)){
//     Console.WriteLine("Y");
// }
// else{
//     Console.WriteLine("No");
// }


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// bool FindElement(int[] array, int el){
//     foreach (var item in array){
//         if (el == item)   return true;
//     }
//     return false;
// }

// -----------------------------------------------------------------
// одн.массив из 123 случ.числел. Посчитать колво чисел от 10 до 99 (вариант foreach)
// int[] a = GetArr(123, 1, 1000);
// Console.WriteLine($"[{String.Join(", ", a)}]");
// Console.WriteLine("add from");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add to");
// int y = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"количество числел в диапазоне от {x} до {y} = {FindElement(x, y)}");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int FindElement(int from, int to){
//     int count = 0;
//     foreach (var n in a){
//         if (n >= from && n < to+1){
//             count ++;
//         }  
//     }
//     return count;
// }

// ------------------------------------------------------------------
// одн.массив из 123 случ.числел. Посчитать колво чисел от 10 до 99 (вариант с for)
// int[] a = GetArr(123, 1, 1000);
// Console.WriteLine($"[{String.Join(", ", a)}]");


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int count = 0;
// for (int i = 0; i < a.Length; i++){
//     if (a[i] >= 10 && a[i] < 100){
//         count++;
//     }
// }
   
// if (count == 0){
//     Console.WriteLine($"не обнаружены числа в диапазоне 10 - 99");
// }
// else {
//     Console.WriteLine($"числа встречены {count} раз в диапазоне 10 - 99");
// }
//----------------------------------------------------

// произведение пар чисел в массиве 
// !!! лишний аргумент pri
// int[] a = GetArr(3, 1, 20);
// Console.WriteLine($"[{String.Join(", ", a)}]");

// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int pri = a.Length - 1;
// for (int i = 0; i < a.Length/2; i++){
//     a[i] = a[i] * a[pri];
//     Console.WriteLine(a[i]);
//     pri = pri - 1;
// }
// if (a.Length % 2 != 0)   Console.WriteLine(a[a.Length/2]);
   
//-----------------------------------------------------
// правильнее
// int[] array = GetArr(6, 1, 20);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// resultArray();


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// void resultArray(){
//     for (int i = 0, j = array.Length - 1; i < array.Length/2; i++, j--)  // несколько параметров одновременно
//     {
//         Console.WriteLine(array[i] * array[j]);
//     }
//     if (array.Length % 2 != 0)   Console.WriteLine(array[array.Length/2]);
// }

//-----------------------------------------------------
// принимаем на вход массив
// int[] array = GetArr(6, 1, 20);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// resultArray(array);


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// void resultArray(int[] x){
//     for (int i = 0, j = x.Length - 1; i < x.Length/2; i++, j--)  // несколько параметров одновременно
//     {
//         Console.WriteLine(x[i] * x[j]);
//     }
//     if (x.Length % 2 != 0)   Console.WriteLine(x[x.Length/2]);
// }

//------------------------------------------------------------
// оптимальный
// int[] a = GetArr(7, 1, 20);
// Console.WriteLine($"[{String.Join(", ", a)}]");
// Console.WriteLine($"[{String.Join(", ", resultArray(a))}]");

// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// int[] resultArray(int[] a){
//     int siz = a.Length/2;
//     if (a.Length % 2 == 1) siz++;
//     int[] result = new int[siz];
//     for (int i = 0; i < a.Length/2; i++){
//         result[i] = a[i] * a[a.Length - 1 - i];
//     }
//     if (a.Length % 2 == 1)   result[siz - 1] = a[a.Length / 2];
//     return result;
// }

// с пред.лекции
// ------------------------------------------------------------------
// int[] array = RandomArray(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int[] RandomArray(int size){
//     int[] a = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         a[i] = new Random().Next(2);
//     }
//     return a;
// }


//---------------------------------------------------------
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
// int[] array = RandomArray(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int[] RandomArray(int size){
//     int[] a = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         a[i] = new Random().Next(2);
//     }
//     return a;
// }

// int[] array = GetArr(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));      // заполнили массив


// int[] GetArr(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));


// void ReversArray(int[] a){    //способ 1, развернуть массив
//     for (int i = 0; i < a.Length/2; i++){
//         int k = a[i];   // временная переменная
//         a[i] = a[a.Length - 1 - i];
//         a[a.Length - 1 - i] = k;
//     }
// }

// int[] res = ReversedArray(array);  //создаем массив для записи - обязательно при этом способе!
// Console.WriteLine(String.Join(" ", res));

// int[] ReversedArray(int[] b){      //  способ 2, записать данные в новый массив
//     int[] result = new int[b.Length];
//     for (int i = 0; i < b.Length; i++){
//         result[i] = b[b.Length - 1 - i];
//     }
//     return result;
// }


// Преобразовать десятичное число в двоичное   - способ1
// Console.WriteLine("Введите число");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Convert.ToString(x, 2));


// Преобразовать десятичное число в двоичное   - способ2. Математически 
// Console.WriteLine("Введите число");
// int x = int.Parse(Console.ReadLine()!);  
// string result = string.Empty;
// while(x > 0){ 
//     result = (x % 2) + result;
//     x = x / 2;
// }
// Console.WriteLine(result);


// Принять 3 числа. Существует ли треугольник с такими сторонами
// Console.WriteLine("Введите число 1");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 2");
// int y = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число 3");
// int h = int.Parse(Console.ReadLine()!);
// Console.WriteLine(BeTriangle(x, y, h));
// теорема неравенства: каждая из сторон треугольника меньше суммы двух других
// bool BeTriangle(int a, int b, int c){
//     if ((a + b) > c && (a + c) > b && (b + c) > a){
//         return true;
//     }
//     else   return false;
// }

// Короткая запись
// bool BeTriangle(int a, int b, int c){
//     return (a + b) > c && (a + c) > b && (b + c) > a;
// }
// if (BeTriangle(x, y, h))   Console.WriteLine("Треугольник существует");
// else   Console.WriteLine("Треугольник не существует");
   
// Копировать массив
int[] array = GetArr(10, 0, 10);
Console.WriteLine(String.Join(" ", array));      // заполнили массив


int[] GetArr(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] res = CopyArray(array);  //создаем массив для записи 
Console.WriteLine(String.Join(" ", res));

int[] CopyArray(int[] b){      //  записать данные в новый массив
    int[] result = new int[b.Length];
    for (int i = 0; i < b.Length; i++){
        result[i] = b[i];
    }
    return result;
}
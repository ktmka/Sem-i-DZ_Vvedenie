// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. 
// Console.WriteLine("add number");
// string n = (Console.ReadLine()!);
// if (n.Length < 5 || n.Length > 5) {
//     Console.WriteLine("число не пятизначное");
// }
// else {
//     int n1 = Convert.ToInt32(n[0]);
//     int n2 = Convert.ToInt32(n[1]);
//     int n4 = Convert.ToInt32(n[3]);
//     int n5 = Convert.ToInt32(n[4]);
//     if (n1 == n5 && n2 == n4) Console.WriteLine("да, число - палиндром");
//     else Console.WriteLine("нет, число - не палиндром");
// }

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// Console.WriteLine("x - координату x точки а");
// int xa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("y - координату y точки а");
// int ya = int.Parse(Console.ReadLine()!);
// Console.WriteLine("z - координату z точки a");
// int za = int.Parse(Console.ReadLine()!);
// Console.WriteLine("x - координату x точки b");
// int xb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("y - координату y точки b");
// int yb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("z - координату z точки b");
// int zb = int.Parse(Console.ReadLine()!);
// double katet1 = Math.Pow((xb - xa), 2);
// double katet2 = Math.Pow((yb - ya), 2);
// double katet3 = Math.Pow((zb - za), 2);
// double ab = Math.Sqrt(katet1 + katet2 + katet3);
// Console.WriteLine($"расстояние ab = {ab:f2}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine()!);
int index = 1;
double x = 1;
while (index <= n){
    x = Math.Pow(index, 3);
    Console.WriteLine(x);
    index++;
}

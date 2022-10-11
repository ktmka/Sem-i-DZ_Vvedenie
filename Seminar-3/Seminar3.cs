// Вариант использования строк. Отобразить третью цифру введенного числа
// Console.WriteLine("add number");
// string number = (Console.ReadLine()!);
// if (number.Length < 3) {
//     Console.WriteLine("отсутствует третья цифра");
// }
// else {
//     Console.WriteLine($"третья цифра {number} = {number[2]}");
// }

// Задача про четверти
// Console.WriteLine("введи четверть");
// int number = int.Parse(Console.ReadLine()!);
// switch(number)
// {
//     case(1):
//         Console.Write("x > 0; ");
//         Console.Write("y > 0");
//         break;
//     case(2):
//         Console.Write("x > 0; ");
//         Console.Write("y < 0");
//         break;
//     case(3):
//         Console.Write("x < 0; ");
//         Console.Write("y < 0");
//         break;
//     case(4):
//         Console.Write("x < 0; ");
//         Console.Write("y > 0");
//         break;
//     default:
//         Console.Write("ошибка");
//         break;
// }

// Задача найти длину отрезка ab (найти гипотенузу по катетам)
// Console.WriteLine("x - координату точки xа");
// int xa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("x - координату точки xb");
// int xb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("y - координату точки yа");
// int ya = int.Parse(Console.ReadLine()!);
// Console.WriteLine("y - координату точки yb");
// int yb = int.Parse(Console.ReadLine()!);
// double katet1 = Math.Pow((xb - xa), 2);
// double katet2 = Math.Pow((yb - ya), 2);
// double ab = Math.Sqrt(katet1 + katet2);
// Console.WriteLine($"{ab:f2}");

// Задача вывести таблицу квадратов от 1 до n
// Console.WriteLine("введите число");
// int n = int.Parse(Console.ReadLine()!);
// int index = 1;
// double x = 1;
// while (index <= n){
//     x = Math.Pow(x, 2);
//     Console.WriteLine(x);
//     x = Math.Sqrt(x);
//     x ++;
//     index++;
// }

// Другой вариант решения (! более простой)
// Console.WriteLine("введите число");
// int n = int.Parse(Console.ReadLine()!);
// int index = 1;
// double x = 1;
// while (index <= n){
//     x = Math.Pow(index, 2);
//     Console.WriteLine(x);
//     index++;
// }

// Задача: определить счастливое число
Console.WriteLine("испытайте удачу, введите число");
string proverka = (Console.ReadLine()!);
if (proverka.Length < 6 || proverka.Length > 6) {
    Console.WriteLine("упс, это число выходит за счастливые границы :)");
}
else {
    int x1 = Convert.ToInt32(proverka[0] + proverka[1] + proverka[2]);
    int x2 = Convert.ToInt32(proverka[3] + proverka[4] + proverka[5]);
    if (x1 == x2)      Console.WriteLine("ура, счастливое число!");
    else               Console.WriteLine("это число обычное");
}


// Вывести случайное число из отрезка [10, 99] и показать наибольшую цифру числа
// int number = new Random().Next(10, 100);
// int num1 = number/10;
// int num2 = number%10;
// Console.WriteLine(number);
// if (num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

// Вариант 2 -----------------------------------
// int number = new Random().Next(10, 100);
// int num1 = number/10;
// int num2 = number%10;
// Console.WriteLine(number);
// int max = num1;
// if (max < num2)
// {
//     max = num2;
// }
// Console.WriteLine(max);

// Задача1 ----------------------------------
// Вывести трехзначное случайное число и удалить вторую цифру этого числа
// int number = new Random().Next(100, 999);
// int num1 = number/100;
// int num2 = number%10;
// Console.WriteLine(number);
// Console.WriteLine($"{num1}{num2}");
// Console.Write(num1);
// Console.Write(num2);

// Задача2 ----------------------------------
// Принимать на вход два числа и вывести, яляется ли второе число кратным первому. Если число не кратно, вывести остаток
// int number1 = new Random().Next(1, 1000);
// int number2 = new Random().Next(1, 1000); // Для эксперимента рандом
// Console.WriteLine(number1);
// Console.WriteLine(number2);
// int number3 = (number2%number1);
// if (number3 == 0)
// {
//     Console.WriteLine($"{number2} кратно {number1}");
// }
// else{
//     Console.WriteLine($"{number2} не кратно {number1}. Остаток = {number3}"); 
// }

// Вариант как в задаче  
// Console.WriteLine("add first number");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("add second number");
// int number2 = int.Parse(Console.ReadLine()!); // как в задаче
// Console.WriteLine(number1);
// Console.WriteLine(number2);
// int number3 = (number2%number1);
// if (number3 == 0)
// {
//     Console.WriteLine($"{number2} кратно {number1}");
// }
// else{
//     Console.WriteLine($"{number2} не кратно {number1}. Остаток = {number3}"); 
// }

// Задача 3. Введенное число кратно ли 7 и 23 (и) ---------------------
// Console.WriteLine("add number");
// int number = int.Parse(Console.ReadLine()!);
// if (number%7 == 0 && number%23 == 0)
// {
//     Console.WriteLine($"{number} кратно 7 и 23");
// }
// else{
//     Console.WriteLine($"{number} не кратно 7 и 23"); 
// }

// Задача 4. Введенные два числа, является лм одно квадратом другого?  (или)---------------
Console.WriteLine("add first number");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("add second number");
int number2 = int.Parse(Console.ReadLine()!); 
Console.WriteLine(number1);
Console.WriteLine(number2);
if (number1 == Math.Pow(number2, 2)  || number2 == Math.Pow(number1, 2))
{
    Console.WriteLine("одно число квадрат другого");
}
else{
    Console.WriteLine("отрицательный ответ"); 
}

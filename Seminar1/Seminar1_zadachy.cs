// Задача про два числа: является ли первое квадратом второго
// Console.WriteLine("Введи первое число");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введи второе число");
// int num2 = int.Parse(Console.ReadLine()!);
// if (Math.Pow(num2, 2) == num1)
// {
//     Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }

// Задача: вывести число, умноженное само на себя
// Console.WriteLine("Введи число");
// int num = int.Parse(Console.ReadLine()!);
// num = Convert.ToInt32(Math.Pow(num, 2));
// Console.WriteLine(num);

// Console.WriteLine("Введи номер дня недели от 1 до 7");
// int num = int.Parse(Console.ReadLine()!);

//     if (num == 1) {
//         Console.WriteLine("Понедельник");
//     }
//     if (num == 2) {
//         Console.WriteLine("Вторник");
//     }
//     if (num == 3) {
//         Console.WriteLine("Среда");
//     }
    // else
    //     Console.WriteLine("Это еще что за день?");
    // Ошибка: Для случая "1" выводит оба варианта


//     Console.WriteLine("Введи номер дня недели от 1 до 7");
// int num = int.Parse(Console.ReadLine()!);
// switch(num)
//     {
//         case 1: 
//         Console.WriteLine("понедельник");
//         break; 
//         case 2: 
//         Console.WriteLine("вторник");
//         break; 
//         default:
//         Console.WriteLine("не знаю такого");
//         break;
//     }

// // Задача про числа от n до -n
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int x = -n;
while (x <= n)
{
    Console.WriteLine($"чиcло {x}");
    x ++;
}





       

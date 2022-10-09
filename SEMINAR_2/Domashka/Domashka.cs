// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// Console.WriteLine("add number");
// int number = int.Parse(Console.ReadLine()!);
// if (number > 99 && number <= 999)
// {
//     int num1 = number%100;
//     int num2 = num1/10;
//     Console.WriteLine(num2);
// }
// else{
//     Console.WriteLine("Ошибка: это число не трехзначное!");
// }


// // Задача 13. Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет
// 
// Console.WriteLine("add number");
// int number = int.Parse(Console.ReadLine()!);
// int num3 = 0;
// if (number >= 0 && number <= 100000)
// {
//     if (number >= 0 && number < 100)        Console.WriteLine("число не имеет третьей цифры");
//     if (number >= 100 && number < 1000)
//     {
//         num3 = number%10; 
//         Console.WriteLine(num3);
//     }                               
//     if (number >= 1000 && number < 10000)
//     {
//         num3 = number%100; 
//         num3 = num3/10; 
//         Console.WriteLine(num3);
//     }                                        
//     if (number >= 10000 && number < 100000)
//     {
//         num3 = number%1000; 
//         num3 = num3/100; 
//         Console.WriteLine(num3);
//     }                                      
//     if (number == 100000){
//         num3 = number%10000; 
//         num3 = num3/1000;
//         Console.WriteLine(num3);
//     }                                         
// }
// else{
//     Console.WriteLine("число выходит за заданные границы");
// }


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным 
Console.WriteLine("задайте номер дня недели");
int day = int.Parse(Console.ReadLine()!);
if (day >= 1 && day <= 7)
{
    if (day == 7 || day == 6)    Console.WriteLine("Да, это выходной!");
    else                         Console.WriteLine("Нет, это не выходной ((");
}
else{
    Console.WriteLine("Ошибка: неверный номер");
}


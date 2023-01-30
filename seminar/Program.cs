// Программа на проверку является ли 1 число квадратом 2го
// int number1 = -3, number2 = 9;
// if (number1/number2 == number2)
// {
//     System.Console.WriteLine($"Да, {number1} является квадратом числа {number2}");
// }
// else
// {
//     System.Console.WriteLine($"Нет, {number1} не является квадратом числа {number2}");
// }

//Программа на вывод дней недели не стала делать

//Программа
// напишите программу, которая на вход принимает одно число (N), а на выходе показывает 
//все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n ,0)
// {
//   n= n*-1;
// }
// else
// {
//    for (int index = -n; index<=n; index++)
//    {
//     System.Console.Write(index + " ");
//     }
// }



// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

System.Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    System.Console.Write("Последняя цифра этого числа - " + n % 10);
}
else
{
    System.Console.Write("Введено не трёхзначное число");
}
// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 1)
{
    System.Console.Write("Введите, пожалуйста, число больше 1");
}

for (int index = 2; index <= N; index+=2)
{
    System.Console.Write(index + " ");
}

﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
while (num > num1){
    num1 += 2;
    Console.WriteLine(num1);
}
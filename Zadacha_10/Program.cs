﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a / 10 % 10);
﻿Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if(num1 > num2) {
    max = num1;
    min = num2;
}
else {
    max = num2;
    min = num1;
}
Console.Write($"Наибольшее число - {max}, а наименьшее - {min}.");
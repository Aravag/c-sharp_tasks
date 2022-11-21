// Работает с отрицательными числами.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0) {
sum += num % 10;
num /= 10;
}
Console.WriteLine($"Сумма цифр числа: {sum}");


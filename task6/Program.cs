Console.Write("Введите любое число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if((num % 2) == 0) {
    Console.Write("Введенное число является четным.");
}
else {
    Console.Write("Введенное число является нечетным.");
}
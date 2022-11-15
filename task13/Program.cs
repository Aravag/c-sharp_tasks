Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = num.ToString();
if(numStr.Length >= 3) {
    Console.Write($"Третьей цифрой числа {num} является {numStr[2]}.");
}
else {
    Console.Write($"Третьей цифры нет.");
}
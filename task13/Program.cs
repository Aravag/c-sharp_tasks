Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numStr = num.ToString();
if(numStr.Length >= 3) {
    Console.Write($"Третьей цифрой является {numStr[2]}.");
}
else {
    Console.Write($"Третьей цифры нет.");
}
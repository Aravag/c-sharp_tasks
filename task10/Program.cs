Console.Write("Введите трехзначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numStr = num.ToString();
if(numStr.Length > 3) {
    Console.Write("Только трехзначное число!");
}
else if(numStr.Length < 3) {
    Console.Write("Только трехзначное число!");
}
else {
    numStr = numStr.Remove(0, 1).Remove(1, 1);
    Console.Write($"Второй цифрой является {numStr}.");
    // Или
    // Console.Write($"Второй цифрой числа {num} является {numStr[1]}.");
}
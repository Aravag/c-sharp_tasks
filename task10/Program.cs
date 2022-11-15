Console.Write("Введите трехзначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numStr = num.ToString();
if(numStr.Length > 3 || numStr.Length < 3) {
    Console.Write("Только трехзначное число!");
}
else {
    Console.Write($"Второй цифрой является {numStr[1]}.");
    // Или
    // numStr = numStr.Remove(0, 1).Remove(1, 1);
    // Console.Write($"Второй цифрой является {numStr}.");
}
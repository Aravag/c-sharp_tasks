Console.Write($"Введите число B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x =(b2-b1)/(k1-k2);  
double y =(k1*(b2-b1))/(k1-k2)+b1;
if((b1 * k2 - b2 * k1) == 0) {
    Console.WriteLine("Прямые параллельны.");
}
if ((k1 == k2) && (b1 == b2)) {
    Console.WriteLine("Прямые совпадают.");
}
Console.Write($"x = {x}, y = {y}.");
Console.Write("Введите первое число: ");
int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Введите второе число: ");
int num2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Введите третье число: ");
int num3 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int max = Math.Max(num1, Math.Max(num2, num3));
Console.Write(max);
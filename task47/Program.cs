Console.WriteLine("-----------------------------------------------------");
Console.Write("Введите число m: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Введите число n: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[,] array = new double[m, n];
double GetRandomNumber(double minimum, double maximum) { 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Массив: ");
Console.WriteLine("-----------------------------------------------------");
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
    array[i, j] = Math.Round(GetRandomNumber(10, -5), 1);  
    Console.Write(array[i, j] + " ");
}
    Console.WriteLine();
}
Console.WriteLine("-----------------------------------------------------");
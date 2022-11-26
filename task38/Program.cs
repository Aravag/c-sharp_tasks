Console.WriteLine("-------------------------------------------------------------------------");
Console.Write("Введите длину массива: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[] array = new double[num];
double GetRandomNumber(double minimum, double maximum) { 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}
double max = 0;
double min = 10;
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++) {
    array[i] = Math.Round(GetRandomNumber(10, 5), 2);
    Console.Write(array[i] + " ");
    if(max<array[i]) {
        max = array[i];
    }
    else if(min>array[i]){
        min = array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Максимальное число - ({max}), минимальное - ({min}), разница - ({Math.Round((max - min), 2)}).");
Console.WriteLine("-------------------------------------------------------------------------");
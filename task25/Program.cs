// Отрицательные числа тоже возводятся в степень
Console.Write("Введите число, которое необходимо возвести в степень: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numB = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 1;
for(int i=1; i<=numB;i++) {
    count = count*numA;
}
Console.WriteLine($"Число {numA} в степени {numB} = {count}");
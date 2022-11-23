// Работает с отрицательными числами.
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (num != 0) {
// sum += num % 10;
// num /= 10;
// }
// Console.WriteLine($"Сумма цифр числа: {sum}");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int number){
    string numStr = Convert.ToString(Math.Abs(number));
    int[] array = new int[numStr.Length];
    int sum = 0;
    for (int i = 0; i < numStr.Length; i++) {
        array[i] = Convert.ToInt32(numStr[i] - 48);
    }
    if(num<0) {
        array[0] *= -1;
    }
    for (int i = 0; i < array.Length; i++) {
        sum += array[i];
    }
    return sum;
}

int sum = Sum(num);
Console.Write(sum);
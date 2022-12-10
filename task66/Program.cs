int SumNum(int m, int n) {
        if (m > n) {
            if (m == n) {
                return m;
            }
            return m + SumNum(m - 1, n);
        } else {
            if (m == n) {
                return m;
            }
            return m + SumNum(m + 1, n);
        }
    }
Console.Write("Введите число M: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Введите число N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (m<n) {
    Console.Write($"Сумма чисел от {m} до {n} равняется {SumNum(m, n)}");
}
else {
    Console.Write($"Сумма чисел от {n} до {m} равняется {SumNum(m, n)}.");
}
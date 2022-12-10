int Akker(int m, int n) {
    if (m == 0) {
        return n + 1;
        }
    else if ((m != 0) && (n == 0)) {
        return Akker(m - 1, 1);
        }
    else {
        return Akker(m - 1, Akker(m, n - 1));
    }
}
Console.Write("Введите число M: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Введите число N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write(Akker(m, n));
void Numbers (int num) {
    if(num == 0) {
        return;
    }
    else {
        Console.Write(num);
        Numbers(num-1);
    }
}
Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Numbers(num);
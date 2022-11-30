Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
void CountNum(int num) {
    if(num>0) {
        num/=10;
        count+=1;
        CountNum(num);
    }
    else {
        Console.Write(count);
        return;
    }
}
CountNum(num);
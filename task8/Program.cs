Console.Write("Введите любое число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for(int i=0; i <= num; i+=2) {
    if(i==0){
        continue;
    }
    Console.WriteLine(i);
}
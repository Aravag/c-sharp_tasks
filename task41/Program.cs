int size = 1;
int count = 0;
int i = 0;
int[] numbers = new int[size];
while(true){
    Console.Write($"Введите число {i+1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    Array.Resize(ref numbers, size+=1);
    i++;
    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить или нажмите <Enter> чтобы закончить ввод");
    if(Console.ReadKey().Key == ConsoleKey.Enter) {
        break;
    }
}
Array.Resize(ref numbers, size-=1);
Console.Write("Вы ввели числа: ");
Console.Write(string.Join(", ", numbers));
for(int j=0;j<numbers.Length;j++) {
    if(numbers[j]>0) {
        count++;
    }
}
Console.WriteLine();
Console.Write($"Количество чисел больше (0): {count}.");
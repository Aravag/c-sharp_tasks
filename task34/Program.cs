int[] array = new int[8];
Random rand = new Random();
int count = 0;
Console.WriteLine("-------------------------------------------------------------------------");
Console.Write("Рандомный массив из 8 трехзначных чисел: ");
for (int i = 0; i < array.Length; i++) {
    array[i] = rand.Next(100, 1000);
    Console.Write(array[i] + " ");
}
for(int i=0; i<array.Length; i++) {
    if(array[i]%2 == 0) {
        count+=1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных трехзначных чисел массива равняется {count}.");
Console.WriteLine("-------------------------------------------------------------------------");
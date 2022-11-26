Console.WriteLine("-------------------------------------------------------------------------");
Console.Write("Введите длину массива: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[num];
Random rand = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = rand.Next(-20, 21);
    Console.Write(array[i] + " ");
}
for(int i=1;i<array.Length; i+=2) {
    count+=array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равняется {count}.");
Console.WriteLine("-------------------------------------------------------------------------");
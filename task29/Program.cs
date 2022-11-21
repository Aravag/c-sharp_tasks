int[] array = new int[8];
Random rand = new Random();
Console.Write("Рандомный массив из 8 чисел: ");
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(1, 51);
    Console.Write(array[i] + " ");
}
int[] FillArray(int size) {
    int[] array = new int[size];
    for(int i=0; i< array.Length; i++) {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(num);
int count = 0;
Console.WriteLine(string.Join(", ", arr));
for(int i=0; i<arr.Length; i++) {
    if(arr[i] > 10 && arr[i] < 99) {
        count+=1;
    }
}
Console.Write($"В данном массиве {count} чисел от 10 до 99.");
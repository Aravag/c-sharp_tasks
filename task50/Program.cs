Console.WriteLine("-----------------------------------------------------");
Console.Write("Введите число строки: ");
int rowPoz = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбца: ");
int columPoz = Convert.ToInt32(Console.ReadLine());
int GetRandomNumber(int from, int to) { 
        Random random = new Random();
        return random.Next(from, to);
}
int row = GetRandomNumber(2, 10);  
int colum = GetRandomNumber(2, 10);  
if(columPoz <= 0 || rowPoz <= 0) {
    Console.WriteLine("Ошибка! Строки или столбцы должны быть больше 0!");
}
else {
    int[,] array = new int[row, colum];
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Массив: ");
    Console.WriteLine("-----------------------------------------------------");
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < colum; j++) {
        array[i, j] = GetRandomNumber(1, 10);
        Console.Write(array[i, j] + " ");
    }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------------");
    if(columPoz > colum || rowPoz > row) {
    Console.WriteLine("Ошибка! Число выходит за массив.");
    Console.WriteLine("-----------------------------------------------------");
    }
    Console.WriteLine($"В массиве по заданным индесам находится число {array[rowPoz, columPoz]}.");
    Console.WriteLine("-----------------------------------------------------");

}
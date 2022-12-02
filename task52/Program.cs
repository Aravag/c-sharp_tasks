Console.WriteLine("-----------------------------------------------------");
Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int colum = Convert.ToInt32(Console.ReadLine());
if(colum <= 0 || row <= 0) {
    Console.WriteLine("Ошибка! Строки или столбцы должны быть больше 0!");
}
else {
    int[,] array = new int[row, colum];
    int GetRandomNumber(int from, int to) { 
        Random random = new Random();
        return random.Next(from, to);
    }
    int[] columSum = new int[colum];
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Массив: ");
    Console.WriteLine("-----------------------------------------------------");
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < colum; j++) {
        array[i, j] = GetRandomNumber(1, 10);  
        Console.Write(array[i, j] + " ");
    }
        for(int m=0; m<colum; m++){ 
            columSum[m]+=array[i, m];
        }
        Console.WriteLine();
    }
    for(int k=0; k<colum; k++) {
        columSum[k]/=row;
    }
    Console.WriteLine("-----------------------------------------------------");
    Console.Write($"Среднее арифметическое каждого столбца равняется: {string.Join(',', columSum)}.");
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------");
}
int GetRandomNumber(int from, int to) { 
        Random random = new Random();
        return random.Next(from, to);
}
int[,] GenerateAndPrintArray(int row, int colum, int from, int to) {
    int[,] array = new int[row, colum];
    Random random = new Random();
    for (int a = 0; a < row; a++) {
        for (int b = 0; b < colum; b++) {
            array[a, b] = random.Next(from, to);
            Console.Write(array[a, b] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine("-----------------------------------------------------");
int colum = GetRandomNumber(3, 5);
int row = GetRandomNumber(3, 5);
Console.WriteLine("Массив");
Console.WriteLine("-----------------------------------------------------");
int[,] array = GenerateAndPrintArray(row, colum, 1, 20);
Console.WriteLine("-----------------------------------------------------");
int[] rowBig = new int[row];
int sum = 0;
Console.WriteLine("Суммы строк: ");
Console.WriteLine("-----------------------------------------------------");
for (int a = 0; a < row; a++) {
    for (int b = 0; b < colum; b++) {
        sum += array[a,b];
    }
    rowBig[a] += sum;
    Console.Write(rowBig[a] + "\t");
    sum = 0;
}
int min = rowBig[0];
int index = 0;
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------");
for(int i=0; i<rowBig.Length; i++) {
    if(rowBig[i]<=min) {
        min = rowBig[i];
        index = i;
    }
    else {
        continue;
    }
}
Console.WriteLine($"На {index+1} строке минимальная сумма элементов.");
Console.WriteLine("-----------------------------------------------------");
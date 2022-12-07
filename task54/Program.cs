int GetRandomNumber(int from, int to) { 
        Random random = new Random();
        return random.Next(from, to);
}
int[,] GenerateArray(int row, int colum) {
    int[,] array = new int[row, colum];
    Random random = new Random();
    for (int a = 0; a < row; a++) {
        for (int b = 0; b < colum; b++) {
            array[a, b] = random.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array) {
    for (int a = 0; a < array.GetLength(0); a++) {
        for (int b = 0; b < array.GetLength(1); b++) {
            Console.Write(array[a, b] + "\t");
        }
        Console.WriteLine();
    }
}
void Sort(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        for (int j = 0; j < array.Length - i - 1; j++) {
            if (array[j] < array[j + 1]) {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}
}
void Insert(bool isRow, int dim, int[] source, int[,] dest) {
    for (int k = 0; k < source.Length; k++) {
        if (isRow) {
            dest[dim, k] = source[k];
        }
        else {
            dest[k, dim] = source[k];
        }
    }
}
Console.WriteLine("-----------------------------------------------------");
int colum = GetRandomNumber(3, 5);
int row = GetRandomNumber(3, 5);
int[,] array = GenerateArray(row, colum);
Console.WriteLine("Массив");
Console.WriteLine("-----------------------------------------------------");
PrintArray(array);
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Отсортированный массив: ");
Console.WriteLine("-----------------------------------------------------");
int[] rowSort = new int[colum];
for (int i = 0; i < row; i++) {
    for (int j = 0; j < colum; j++){
        rowSort[j] = array[i, j];
    }
    Sort(rowSort);
    Insert(true, i, rowSort, array);
}
PrintArray(array);
Console.WriteLine("-----------------------------------------------------");
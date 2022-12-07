int[,,] GenerateAndPrintArray(int x, int y, int z, int from, int to) {
    int[,,] array = new int[x, y, z];
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number = 0;
    for (int i = 0; i < temp.GetLength(0); i++) {
        temp[i] = new Random().Next(from, to);
        number = temp[i];
    if (i >= 1) {
        for (int j = 0; j < i; j++) {
        while (temp[i] == temp[j]) {
            temp[i] = new Random().Next(from, to);
            j = 0;
            number = temp[i];
        }
            number = temp[i];
        }
    }
    }
    int count = 0; 
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                array[i, j, k] = temp[count];
                count++;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-----------------------------------------------------");
    }
    return array;
}

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Массив");
Console.WriteLine("-----------------------------------------------------");
int[,,] array = GenerateAndPrintArray(2, 2, 2, 10, 100);
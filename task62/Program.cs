// int row = 8;
// int colum = 8;
// int count = 1;
// int[,] array = new int[row, colum];
// for(int i=0; i<colum; i++) {
//     array[0,i] = count;
//     count++;
// }
// for(int i=0; i<row; i++) {
//     array[i,colum-1] = count;
//     count++;
// }
// for(int i=colum-1; i<colum-1; i--) {
//     array[row-1,i] = count;
//     count++;
// }
// for (int i = 0; i < array.GetLength(0); i++) {
//     for (int j = 0; j < array.GetLength(1); j++) {
//         Console.Write(array[i, j]);
//     }
//     Console.WriteLine();
// }
void PrintArray(int[,] a) {
    for (int i = 0; i < a.GetLength(0); i++) {
        for (int j = 0; j < a.GetLength(1); j++) {
            if(a[i, j] < 10) {
                Console.Write($"0{a[i, j]} ");
            }
            else {
                Console.Write($"{a[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
Console.Write("Введите любое число больше 1: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
int[,] a = new int[n, n];
int i = 0, j = 0;
int value = 1;
while (n != 0) {
    int k = 0;
    do {
        a[i, j++] = value++; 
    } 
    while (++k < n - 1);
    for(k = 0; k < n - 1; k++) {
        a[i++, j] = value++;
    }
    for(k = 0; k < n - 1; k++) {
        a[i, j--] = value++;
    }
    for(k = 0; k < n - 1; k++) {
        a[i--, j] = value++;
    }
    ++i; ++j; n = n < 2 ? 0 : n - 2;
}
PrintArray(a);
Console.WriteLine();
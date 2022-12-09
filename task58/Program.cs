int row = 2;
int colum = 2;
int[,] arrayA = new int[row, colum];
int[,] arrayB = new int[row, colum];
void PrintArray(int[,] array) {
    for(int i=0; i<row; i++) {
        for(int j=0; j<colum; j++) {
            Console.Write(array[i,j] + "\t ");
        }
        Console.WriteLine();
    }
}
for(int i=0; i<row; i++) {
    for(int j=0; j<colum; j++) {
        arrayA[i,j] = new Random().Next(1,10);
        arrayB[i,j] = new Random().Next(1,10);
    }
}
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Первая матрица: ");
Console.WriteLine("-----------------------------------------------------");
PrintArray(arrayA);
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Вторая матрица: ");
Console.WriteLine("-----------------------------------------------------");
PrintArray(arrayB);
Console.WriteLine("-----------------------------------------------------");
int[,] arrayC = new int[row, colum];
for(int i=0; i<row; i++) {
    for(int j=0; j<colum; j++) {
        for(int k=0; k<colum; k++) {
            arrayC[i,j] += arrayA[i,k]*arrayB[k,j];
        }
    }
}
Console.WriteLine("Произведение матриц: ");
Console.WriteLine("-----------------------------------------------------");
PrintArray(arrayC);
Console.WriteLine("-----------------------------------------------------");
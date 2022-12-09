// Все работает, только есть лишняя пустая строка в новом массиве. 
// Буду рад, если подскажете, как доделать!
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
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Массив: ");
    Console.WriteLine("-----------------------------------------------------");
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1, 20);  
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------------");
    int min = array[0,0];
    int indexI = 0;
    int indexJ = 0;
    for(int i=0; i<array.GetLength(0); i++) {
        for(int j=0; j<array.GetLength(1); j++) {
            if(array[i,j]<=min) {
                min = array[i,j];
                indexI = i;
                indexJ = j;
            }
            else {
                continue;
            }
        }
    }
    int[,] newArr = new int[row+1, colum+1];
    Console.WriteLine($"Число {min} с индексом ({indexI}, {indexJ}) является минимальным.");
    Console.WriteLine("-----------------------------------------------------");
    for(int i=0; i<newArr.GetLength(0)-1; i++) {
        for(int j=0; j<newArr.GetLength(1)-1; j++) {
            if(i == indexI || j == indexJ) {
                continue;
            }
            else {
                newArr[i,j] = array[i,j];
                Console.Write(newArr[i, j] + "\t ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------------");
}
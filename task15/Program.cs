Console.Write("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7){
    Console.Write("Дней недели всего 7!");
}
else {
    if(num == 6 || num == 7) {
        Console.Write("Это выходной день!");
    }
    else {
        Console.Write("Это будний день!");
    }
}

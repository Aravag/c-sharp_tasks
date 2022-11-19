Console.Write("Введите пятизначное число для проверки на палиндром: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string stringNum = Convert.ToString(num);
if(stringNum.Length > 5 || stringNum.Length < 5){
    Console.Write("Введите пятизначное число!!!");
} 
else {
    if(stringNum[0] == stringNum[4] && stringNum[1] == stringNum[3]) {
        Console.Write("Введенное число является палиндромом!");
    }
    else {
        Console.Write("Введенное число НЕ является палиндромом.");
    }
}
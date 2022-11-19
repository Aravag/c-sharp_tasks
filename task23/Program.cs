Console.Write("Введите число, чтобы увидеть таблицу кубов: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<0){
    num*=-1;
    for(int i=1; i<=num; i++) {
        if(i==num){
        Console.Write($"{-Math.Pow(i,3)}.");
        }
        else{
        Console.Write($"{-Math.Pow(i,3)}, ");
        }
    }
}
else if(num==0){
        Console.Write("Нельзя возвести 0 в куб!");
}
else {
    for(int i=1; i<=num; i++) {
        if(i==num){
        Console.Write($"{Math.Pow(i,3)}.");
        }
        else{
        Console.Write($"{Math.Pow(i,3)}, ");
        }
    }
}

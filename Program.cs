// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
int n=5; // Эта наша разрядность, работает с любой
Console.Write ($"Введите {n}-значное число: "); //Пусть у нас добросовестный пользователь (без проверки разряда)
int num=int.Parse (Console.ReadLine()!);
bool polynom=true; //Пусть у нас полином, попробуем опровергнуть
for (int i=1;i<=n/2;i++) { //Проверим от начала числа к середине и от конца к серидине чтобы все были равны, 
//пойдем как бы одновременно зеркально
    int leftSymbol=num/Convert.ToInt32(Math.Pow(10,n-i)); // Цифры от начала к текущему i
    int rightSymbol=num%Convert.ToInt32(Math.Pow(10,i)); // Цифры от конца к текущему i
    if (i>1) //Если это не первый шаг, то у нас будет несколько цифр, обрежим
    {
        leftSymbol=leftSymbol%10; //Интересна последняя
        rightSymbol=rightSymbol/Convert.ToInt32(Math.Pow(10,i-1)); //Интересна первая
    }
    if (leftSymbol!=rightSymbol) {
        polynom=false;
        break; // Зачем идти дальше
    }
}
if (polynom) {
    Console.WriteLine ($"{num} -> да");
}
else {
    Console.WriteLine ($"{num} -> нет");
}
*/
//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.WriteLine ("Координаты точки A:");
Console.Write ("X: ");
int ax=int.Parse (Console.ReadLine()!);//не будем хранить в double, Math.Pow прекрасно ест int
Console.Write ("Y: ");
int ay=int.Parse (Console.ReadLine()!);
Console.Write ("Z: ");
int az=int.Parse (Console.ReadLine()!);

Console.WriteLine ("Координаты точки B:");
Console.Write ("X: ");
int bx=int.Parse (Console.ReadLine()!);
Console.Write ("Y: ");
int by=int.Parse (Console.ReadLine()!);
Console.Write ("Z: ");
int bz=int.Parse (Console.ReadLine()!);

double d=Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2)+Math.Pow((az-bz),2));
Console.WriteLine ($"A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {d:f2}");
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write ("Введите N: ");
int n=int.Parse (Console.ReadLine()!);
Console.Write ($"{n} -> ");
for (int i=1; i<=n;i++) {
    Console.Write (Math.Pow(i,3));
    if (i<n) Console.Write (", ");
}

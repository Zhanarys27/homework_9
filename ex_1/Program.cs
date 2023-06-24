// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




void Natural(int num)
{
    while(num>0)
    {
        if(num!=0)
        {
            System.Console.Write($"{num}, ");
        }
        num--;
    }
}


string Natural2(int num)
{
    if(num == 1) return $"{num}";
    else return $"{num}, " + Natural2(num-1) ;
}

Console.Clear();
System.Console.WriteLine("Введите значение: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Natural2(num));


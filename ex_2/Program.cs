// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Summary(int num1, int num2)
{
    if(num1 == num2) return num2;
    else return num2 + Summary(num1, num2 -1);
}

Console.Clear();
System.Console.WriteLine("Введите первичное значение");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторичное значение");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Summary(num1,num2));
//Программа, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел
double a; double b; double c;
string? input1;
string? input2;
string? input3;
Console.WriteLine("Введите число a");
input1 = Console.ReadLine();
a = Double.Parse(input1);
Console.WriteLine("Введите число b");
input2 = Console.ReadLine();
b = Double.Parse(input2);
Console.WriteLine("Введите число c");
input3 = Console.ReadLine();
c = Double.Parse(input3);
if(a > b)
{
    if(a > c)
    {
        Console.WriteLine("Максимальное число " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число " + c);
    }
}
else
{
    if(b > c)
    {
        Console.WriteLine("Максимальное число " + b);
    }
    else
    {
        Console.WriteLine("Максимальное число " + c);
    }
}


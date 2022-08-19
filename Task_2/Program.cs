//Программа, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее
double a;
double b;
string? input1;
string? input2;
Console.WriteLine("Введите число a");
input1 = Console.ReadLine();
a = Double.Parse(input1);
Console.WriteLine("Введите число b");
input2 = Console.ReadLine();
b = Double.Parse(input2);
if(a > b)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + b);
}

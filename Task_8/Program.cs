//Программа, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N
int N; int number;
number = 1;
Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
if(N < 0)
{
    N = -N;
    while(number < N)
{
    if(number % 2 == 0)
    {
        Console.Write("-" + number + ", ");
    }
    number++;
}
if(number % 2 == 0)
    {
        Console.Write("-" + number);
    }
}
while(number < N)
{
    if(number % 2 == 0)
    {
        Console.Write(number + ", ");
    }
    number++;
}
if(number % 2 == 0)
    {
        Console.Write(number);
    }

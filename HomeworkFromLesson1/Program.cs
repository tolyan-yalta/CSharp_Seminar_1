//Два друга движутся на встречу друг другу. Расстояние между ними 10 км.
//Скорость первого друга 1 м/с, скорость второго 2 м/с.
//Собака бежит от первого к второму, затем назад к первому и т.д.
//Вопрос. Перед тем как друзья встретятся, сколько раз собака
//перебежит между ними?

int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++; 
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");

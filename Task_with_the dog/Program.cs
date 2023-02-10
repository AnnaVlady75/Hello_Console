double count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed  = 2;
int dogSpeed = 5;
bool Friend = 2;

while(distance>10)
{    if(Friend = 1)
{
    time = distance / (firstFriendSpeed+dogSpeed);
    Friend = 2;
}
else
{
    time = distance / (secondFriendSpeed+dogSpeed);
    Friend = 1;
}
distance = distance - distance(firstFriendSpeed+socondFriendSpeed) * time;
Console.Write("count = ");
Console.WriteLine(count);
count = count + 1;
}


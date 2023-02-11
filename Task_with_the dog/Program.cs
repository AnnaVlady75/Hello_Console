double count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed  = 2;
int dogSpeed = 5;
string Friend = Console.ReadLine();
int time = Console.

while(distance>10)
{   
     if(Friend == 1)
{
    time = distance / (firstFriendSpeed+dogSpeed);
    Friend = 2;
}
else
{
    time = distance / (secondFriendSpeed+dogSpeed);
    Friend = 1;
}
distance = distance - distance(firstFriendSpeed+secondFriendSpeed) * time;
Console.Write("count = ");
Console.WriteLine(count);
count = count + 1;
}


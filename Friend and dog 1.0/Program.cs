using System;

int firstFriendSpeed = 2;
int secondFriendSpeed = 3;
int dogSpeed = 5;
int distance = 10000;
int friend = 2;
int time = 0;
int count = 0;

while (distance > 5)
{
    if (friend == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine(count);

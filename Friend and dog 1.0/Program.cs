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
    if (friend = 1)
    {
        GetTime(time) = GetDistance(distance) / secondFriendSpeed + dogSpeed;
        friend = 1;
    }
    else
    {
        GetTime(time) = GetDistance(distance) / firstFriendSpeed + dogSpeed;
        friend = 2;
    }
}
count++;
int distance = distance - firstFriendSpeed + secondFriendSpeed * time;

Console.WriteLine(count);

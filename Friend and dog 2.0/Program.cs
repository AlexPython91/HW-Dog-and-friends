using System;



Console.WriteLine("Приветствуем Вас!");
    
    Console.Write("Введите скорость первого друга: ");
        string userAnswer = Console.ReadLine();
        int friend1 = Convert.ToInt32(userAnswer);
        int firstFriendSpeed = friend1;
        Console.WriteLine("Скорость первого друга = " + friend1);

    Console.Write("Введите скорость второго друга: ");
        string userAnswer2 = Console.ReadLine();
        int friend2 = Convert.ToInt32(userAnswer2);
        int secondFriendSpeed = friend2;
        Console.WriteLine("Скорость второго друга = " + friend2);

    Console.Write("Введите скорость собаки: ");
        string userAnswer3 = Console.ReadLine();
        int dog = Convert.ToInt32(userAnswer3);
        int dogSpeed = dog;
        Console.WriteLine("Скорость собаки = " + dog);

    Console.Write("Введите расстояние: ");
        string userAnswer4 = Console.ReadLine();
        int totalDistance = Convert.ToInt32(userAnswer4);
        int distance = totalDistance;
        Console.WriteLine("Расстояние = " + totalDistance);
    

        int FriendSpeedOne = friend1;
        int FriendSpeedTwo = friend2;
        int SpeedOfDog = dog;
        int way = totalDistance; 
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
            Console.WriteLine("Собака пробежит: " + count + " раз");
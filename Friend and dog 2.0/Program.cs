Console.WriteLine("Приветствуем Вас!");
    
    Console.Write("Введите скорость первого друга: ");
        int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
                        
    Console.Write("Введите скорость второго друга: ");
        int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
        
    Console.Write("Введите скорость собаки: ");
        int dogSpeed = Convert.ToInt32(Console.ReadLine());
        
    Console.Write("Введите расстояние: ");
        int distance = Convert.ToInt32(Console.ReadLine());
          
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
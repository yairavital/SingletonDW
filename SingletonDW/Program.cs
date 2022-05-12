using SingletonDW;

Clock clock = Clock.GetTime();
Clock clock1 = Clock.GetTime();
if (clock.Equals(clock1))
    Console.WriteLine("The same instance");
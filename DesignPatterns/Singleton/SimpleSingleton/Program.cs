// Eager Initialization
// Instance of a singleton class is created even though client application is not using it
Singleton firstsingleton = Singleton.Instance;

Console.WriteLine("Initial counter value");
Console.WriteLine(firstsingleton.Counter);

Console.WriteLine("Increment initial counter value by 1.");
firstsingleton.Counter++;

Console.WriteLine("Second instance is created.");
Singleton secondSingleton = Singleton.Instance;

Console.WriteLine("Second instance access counter value");
Console.WriteLine(secondSingleton.Counter);


Console.WriteLine("Second instance increment counter value by 1.");
secondSingleton.Counter++;

Console.WriteLine("Second instance access counter value");
Console.WriteLine(secondSingleton.Counter);

Console.WriteLine("First instance access counter value");
Console.WriteLine(firstsingleton.Counter);

Console.ReadLine();